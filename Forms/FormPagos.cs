using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormPagos : Form
    {
        public FormPagos() { InitializeComponent(); }

        private void FormPagos_Load(object sender, EventArgs e) { CargarEstudiantes(); }

        private void CargarEstudiantes()
        {
            try
            {
                using (var con = Conexion.Abrir())
                using (var da = new MySqlDataAdapter(
                    "SELECT IdEstudiante, CONCAT(Nombre,' ',Apellido,' - ',Curso,Seccion) AS NombreCompleto FROM Estudiantes WHERE Activo=1 ORDER BY Apellido", con))
                {
                    var dt = new DataTable(); da.Fill(dt);
                    var fila = dt.NewRow(); fila["IdEstudiante"] = 0; fila["NombreCompleto"] = "-- Seleccionar --"; dt.Rows.InsertAt(fila, 0);
                    cmbEstudiante.DataSource = dt;
                    cmbEstudiante.DisplayMember = "NombreCompleto";
                    cmbEstudiante.ValueMember   = "IdEstudiante";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedValue != null)

            {
                int idEstudiante;
                // Intentamos convertir el valor. Si es un número válido, cargamos los pagos.
                if (int.TryParse(cmbEstudiante.SelectedValue.ToString(), out idEstudiante))
                {
                    if (idEstudiante > 0)
                    {
                        CargarPagosEstudiante(idEstudiante);
                    }
                }
            }
        }
        
        private void CargarPagosEstudiante(int idEst)
        {
            try
            {
                using (var con = Conexion.Abrir())
                {
                    string sql = "SELECT Fecha, Mes, Monto, Concepto, Estado FROM Pagos WHERE IdEstudiante=@id ORDER BY Fecha DESC";
                    using (var da = new MySqlDataAdapter(sql, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@id", idEst);
                        var dt = new DataTable(); da.Fill(dt); dgvPagos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstudiante.SelectedValue == null || Convert.ToInt32(cmbEstudiante.SelectedValue) == 0)
                { MessageBox.Show("Selecciona un estudiante.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }
                if (!decimal.TryParse(txtMonto.Text.Replace(",","."), System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out decimal monto) || monto <= 0)
                { MessageBox.Show("El monto debe ser un número mayor a 0.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }
                if (string.IsNullOrWhiteSpace(txtConcepto.Text))
                { MessageBox.Show("Ingresa el concepto del pago.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }

                int idEst = Convert.ToInt32(cmbEstudiante.SelectedValue);
                long idPago;

                using (var con = Conexion.Abrir())
                {
                    // INSERT Pago
                    string sqlPago = @"INSERT INTO Pagos (IdEstudiante,Fecha,Mes,Monto,Concepto,Estado)
                                       VALUES(@e,@f,@m,@mo,@co,'Pagado')";
                    using (var cmd = new MySqlCommand(sqlPago, con))
                    {
                        cmd.Parameters.AddWithValue("@e",  idEst);
                        cmd.Parameters.AddWithValue("@f",  dtpFecha.Value.Date);
                        cmd.Parameters.AddWithValue("@m",  cmbMes.Text);
                        cmd.Parameters.AddWithValue("@mo", monto);
                        cmd.Parameters.AddWithValue("@co", txtConcepto.Text.Trim());
                        cmd.ExecuteNonQuery();
                        idPago = cmd.LastInsertedId;
                    }

                    // INSERT Factura automática
                    string numFac = "FAC-" + idPago.ToString("D4");
                    string sqlFac = @"INSERT INTO Facturas (IdPago,IdEstudiante,NumFactura,FechaEmision,Total,Estado)
                                      VALUES(@ip,@ie,@nf,@fe,@t,'Emitida')";
                    using (var cmd2 = new MySqlCommand(sqlFac, con))
                    {
                        cmd2.Parameters.AddWithValue("@ip", idPago);
                        cmd2.Parameters.AddWithValue("@ie", idEst);
                        cmd2.Parameters.AddWithValue("@nf", numFac);
                        cmd2.Parameters.AddWithValue("@fe", dtpFecha.Value.Date);
                        cmd2.Parameters.AddWithValue("@t",  monto);
                        cmd2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Pago registrado y factura {("FAC-"+idPago.ToString("D4"))} generada correctamente.",
                    "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(null, null);
                CargarPagosEstudiante(idEst);
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            cmbMes.SelectedIndex = DateTime.Today.Month - 1;
            txtMonto.Clear(); txtConcepto.Clear(); txtMonto.Focus();
        }
    }
}
