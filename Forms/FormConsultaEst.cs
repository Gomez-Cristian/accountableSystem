using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormConsultaEst : Form
    {
        public FormConsultaEst() { InitializeComponent(); }
        private void FormConsultaEst_Load(object sender, EventArgs e) { }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(filtro)) { MessageBox.Show("Ingresa un nombre o apellido.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }
            try
            {
                using (var con = Conexion.Abrir())
                {
                    string sql = @"SELECT e.IdEstudiante, e.Nombre, e.Apellido, e.Curso, e.Seccion,
                                          e.FechaIngreso,
                                          CASE WHEN e.Activo=1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,
                                          COALESCE(c.NombreTutor,'Sin contacto') AS Tutor,
                                          COALESCE(c.Telefono,'-') AS Telefono
                                   FROM   Estudiantes e
                                   LEFT   JOIN Contactos c ON c.IdEstudiante=e.IdEstudiante
                                   WHERE  e.Nombre LIKE @f OR e.Apellido LIKE @f
                                   ORDER  BY e.Apellido";
                    using (var da = new MySqlDataAdapter(sql, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@f","%"+filtro+"%");
                        var dt = new DataTable(); da.Fill(dt);
                        dgvResultados.DataSource = dt;
                        lblConteo.Text = $"Resultados encontrados: {dt.Rows.Count}";
                    }
                }
                if (dgvResultados.Columns.Contains("IdEstudiante")) dgvResultados.Columns["IdEstudiante"].Visible=false;
            }
            catch (Exception ex) { MessageBox.Show("Error: "+ex.Message); }
        }

        private void dgvResultados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResultados.CurrentRow == null) return;
            var row = dgvResultados.CurrentRow;
            lblDetNombre.Text    = $"Nombre: {row.Cells["Nombre"].Value} {row.Cells["Apellido"].Value}";
            lblDetCurso.Text     = $"Curso: {row.Cells["Curso"].Value} {row.Cells["Seccion"].Value}";
            lblDetIngreso.Text   = $"Ingreso: {Convert.ToDateTime(row.Cells["FechaIngreso"].Value):dd/MM/yyyy}";
            lblDetEstado.Text    = $"Estado: {row.Cells["Estado"].Value}";
            lblDetTutor.Text     = $"Tutor: {row.Cells["Tutor"].Value}";
            lblDetTelefono.Text  = $"Tel: {row.Cells["Telefono"].Value}";
            // Cargar pagos del estudiante seleccionado
            int idEst = Convert.ToInt32(row.Cells["IdEstudiante"].Value);
            try
            {
                using (var con = Conexion.Abrir())
                using (var da = new MySqlDataAdapter("SELECT Fecha,Mes,Monto,Estado FROM Pagos WHERE IdEstudiante=@id ORDER BY Fecha DESC LIMIT 5",con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id",idEst);
                    var dt = new DataTable(); da.Fill(dt); dgvPagos.DataSource=dt;
                }
            }
            catch { }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear(); dgvResultados.DataSource=null; dgvPagos.DataSource=null;
            lblConteo.Text=""; lblDetNombre.Text=""; lblDetCurso.Text="";
            lblDetIngreso.Text=""; lblDetEstado.Text=""; lblDetTutor.Text=""; lblDetTelefono.Text="";
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode==Keys.Enter) btnBuscar_Click(sender,e); }
    }
}
