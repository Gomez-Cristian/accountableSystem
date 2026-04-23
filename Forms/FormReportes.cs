using System;
using System.Data;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormReportes : Form
    {
        public FormReportes() { InitializeComponent(); }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            CargarFiltros();
            ActualizarDashboard();
            CargarReporteMes();
        }

        // ── Cargar meses disponibles en el combo ─────────────────────────
        private void CargarFiltros()
        {
            cmbMes.Items.Clear();
            cmbMes.Items.Add("-- Todos los meses --");
            cmbMes.Items.AddRange(new object[]{"Enero","Febrero","Marzo","Abril","Mayo","Junio",
                                               "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"});
            cmbMes.SelectedIndex = 0;
        }

        // ── KPIs del Dashboard ───────────────────────────────────────────
        private void ActualizarDashboard()
        {
            try
            {
                using (var con = Conexion.Abrir())
                {
                    // Total recaudado
                    using (var cmd = new MySqlCommand("SELECT COALESCE(SUM(Monto),0) FROM Pagos WHERE Estado='Pagado'", con))
                        lblKpiTotal.Text = $"RD$ {Convert.ToDecimal(cmd.ExecuteScalar()):N2}";

                    // Estudiantes activos
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM Estudiantes WHERE Activo=1", con))
                        lblKpiEstudiantes.Text = cmd.ExecuteScalar().ToString();

                    // Facturas emitidas
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM Facturas WHERE Estado='Emitida'", con))
                        lblKpiFacturas.Text = cmd.ExecuteScalar().ToString();

                    // Total mes actual
                    string mesActual = DateTime.Today.ToString("MMMM", new System.Globalization.CultureInfo("es-ES"));
                    mesActual = char.ToUpper(mesActual[0]) + mesActual.Substring(1);
                    using (var cmd = new MySqlCommand("SELECT COALESCE(SUM(Monto),0) FROM Pagos WHERE Mes=@m AND Estado='Pagado'", con))
                    {
                        cmd.Parameters.AddWithValue("@m", mesActual);
                        lblKpiMesActual.Text = $"RD$ {Convert.ToDecimal(cmd.ExecuteScalar()):N2}";
                    }
                }
                CargarGrafico();
            }
            catch (Exception ex) { MessageBox.Show("Error cargando dashboard: " + ex.Message); }
        }

        // ── Gráfico de barras: pagos por mes ─────────────────────────────
        private void CargarGrafico()
        {
            try
            {
                chartPagos.Series.Clear();
                chartPagos.ChartAreas[0].BackColor          = Color.FromArgb(248, 250, 255);
                chartPagos.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 230, 255);
                chartPagos.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 230, 255);
                chartPagos.ChartAreas[0].AxisX.LabelStyle.Font     = new Font("Segoe UI", 7.5f);
                chartPagos.ChartAreas[0].AxisY.LabelStyle.Font     = new Font("Segoe UI", 7.5f);
                chartPagos.BackColor = Color.White;

                var serie = new Series("Pagos por Mes")
                {
                    ChartType  = SeriesChartType.Column,
                    Color      = Color.FromArgb(37, 99, 235),
                    BorderColor= Color.FromArgb(30, 58, 95),
                    BorderWidth= 1,
                    IsValueShownAsLabel = true,
                    Font       = new Font("Segoe UI", 7f, FontStyle.Bold),
                    LabelForeColor = Color.FromArgb(30, 58, 95)
                };

                string[] meses = {"Enero","Febrero","Marzo","Abril","Mayo","Junio",
                                   "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};

                using (var con = Conexion.Abrir())
                {
                    foreach (var mes in meses)
                    {
                        using (var cmd = new MySqlCommand("SELECT COALESCE(SUM(Monto),0) FROM Pagos WHERE Mes=@m AND Estado='Pagado'", con))
                        {
                            cmd.Parameters.AddWithValue("@m", mes);
                            decimal val = Convert.ToDecimal(cmd.ExecuteScalar());
                            serie.Points.AddXY(mes.Substring(0, 3), val);
                        }
                    }
                }
                chartPagos.Series.Add(serie);
            }
            catch (Exception ex) { MessageBox.Show("Error en gráfico: " + ex.Message); }
        }

        // ── Tabla de reporte por mes ─────────────────────────────────────
        private void CargarReporteMes()
        {
            try
            {
                string filtroMes = cmbMes.SelectedIndex > 0 ? cmbMes.Text : "";
                using (var con = Conexion.Abrir())
                {
                    string sql = @"SELECT CONCAT(e.Nombre,' ',e.Apellido) AS Estudiante,
                                          p.Mes, SUM(p.Monto) AS TotalPagado, COUNT(*) AS NroPagos
                                   FROM   Pagos p
                                   INNER  JOIN Estudiantes e ON e.IdEstudiante=p.IdEstudiante
                                   WHERE  p.Estado='Pagado'
                                     AND  (@mes='' OR p.Mes=@mes)
                                   GROUP  BY e.IdEstudiante, p.Mes
                                   ORDER  BY p.Mes, e.Apellido";
                    using (var da = new MySqlDataAdapter(sql, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@mes", filtroMes);
                        var dt = new DataTable(); da.Fill(dt); dgvReporte.DataSource = dt;
                    }

                    // Total del filtro
                    string sqlTotal = "SELECT COALESCE(SUM(Monto),0) FROM Pagos WHERE Estado='Pagado'" +
                                      (filtroMes != "" ? " AND Mes=@mes" : "");
                    using (var cmd = new MySqlCommand(sqlTotal, con))
                    {
                        if (filtroMes != "") cmd.Parameters.AddWithValue("@mes", filtroMes);
                        decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalMes.Text = $"Total del reporte: RD$ {total:N2}";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGenerar_Click(object sender, EventArgs e) { CargarReporteMes(); }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0) { MessageBox.Show("No hay datos para exportar."); return; }
            using (var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "reporte_pagos.csv" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var sb = new StringBuilder();
                    for (int i = 0; i < dgvReporte.Columns.Count; i++)
                        sb.Append((i > 0 ? "," : "") + dgvReporte.Columns[i].HeaderText);
                    sb.AppendLine();
                    foreach (DataGridViewRow row in dgvReporte.Rows)
                    {
                        for (int i = 0; i < dgvReporte.Columns.Count; i++)
                            sb.Append((i > 0 ? "," : "") + "\"" + row.Cells[i].Value + "\"");
                        sb.AppendLine();
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Archivo exportado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }
    }
}
