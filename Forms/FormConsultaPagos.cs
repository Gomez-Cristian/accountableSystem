using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormConsultaPagos : Form
    {
        public FormConsultaPagos() { InitializeComponent(); }
        private void FormConsultaPagos_Load(object sender, EventArgs e) { CargarEstudiantes(); }

        private void CargarEstudiantes()
        {
            try
            {
                using (var con = Conexion.Abrir())
                using (var da = new MySqlDataAdapter(
                    "SELECT IdEstudiante, CONCAT(Nombre,' ',Apellido,' - ',Curso,Seccion) AS NombreCompleto FROM Estudiantes WHERE Activo=1 ORDER BY Apellido",con))
                {
                    var dt=new DataTable(); da.Fill(dt);
                    var f=dt.NewRow(); f["IdEstudiante"]=0; f["NombreCompleto"]="-- Seleccionar --"; dt.Rows.InsertAt(f,0);
                    cmbEstudiante.DataSource=dt; cmbEstudiante.DisplayMember="NombreCompleto"; cmbEstudiante.ValueMember="IdEstudiante";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: "+ex.Message); }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbEstudiante.SelectedValue==null||Convert.ToInt32(cmbEstudiante.SelectedValue)==0)
            { MessageBox.Show("Selecciona un estudiante.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }
            int idEst = Convert.ToInt32(cmbEstudiante.SelectedValue);
            try
            {
                using (var con = Conexion.Abrir())
                {
                    string sql="SELECT Fecha,Mes,Monto,Concepto,Estado FROM Pagos WHERE IdEstudiante=@id ORDER BY Fecha DESC";
                    using (var da=new MySqlDataAdapter(sql,con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@id",idEst);
                        var dt=new DataTable(); da.Fill(dt); dgvPagos.DataSource=dt;
                    }
                    decimal total = 0; int count = 0;
                    using (var cmd=new MySqlCommand("SELECT COUNT(*),COALESCE(SUM(Monto),0) FROM Pagos WHERE IdEstudiante=@id AND Estado='Pagado'",con))
                    {
                        cmd.Parameters.AddWithValue("@id",idEst);
                        using (var dr=cmd.ExecuteReader()) { if(dr.Read()){count=dr.GetInt32(0);total=dr.GetDecimal(1);} }
                    }
                    lblTotal.Text  = $"Total Pagado: RD$ {total:N2}";
                    lblMeses.Text  = $"Meses Pagados: {count}";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: "+ex.Message); }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvPagos.Rows.Count == 0) { MessageBox.Show("No hay datos para exportar."); return; }
            using (var sfd = new SaveFileDialog { Filter="CSV|*.csv", FileName="pagos_exportados.csv" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var sb = new StringBuilder();
                    for (int i = 0; i < dgvPagos.Columns.Count; i++)
                        sb.Append((i>0?",":"") + dgvPagos.Columns[i].HeaderText);
                    sb.AppendLine();
                    foreach (DataGridViewRow row in dgvPagos.Rows)
                    {
                        for (int i = 0; i < dgvPagos.Columns.Count; i++)
                            sb.Append((i>0?",":"") + "\"" + row.Cells[i].Value + "\"");
                        sb.AppendLine();
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Exportado correctamente.","OK",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Error al exportar: "+ex.Message); }
            }
        }
    }
}
