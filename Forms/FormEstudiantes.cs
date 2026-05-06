using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormEstudiantes : Form
    {
        private int _idEditando = 0;
        public FormEstudiantes() { InitializeComponent(); }

        private void FormEstudiantes_Load(object sender, EventArgs e) { CargarEstudiantes(); }

        private void CargarEstudiantes(string filtro = "")
        {
            try
            {
                using (var con = Conexion.Abrir())
                {
                    string sql = @"SELECT IdEstudiante, Nombre, Apellido, Curso, Seccion,
                                          FechaIngreso,
                                          CASE WHEN Activo=1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                                   FROM Estudiantes
                                   WHERE (Nombre LIKE @f OR Apellido LIKE @f)
                                   ORDER BY Apellido, Nombre";
                    using (var da = new MySqlDataAdapter(sql, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@f", "%" + filtro + "%");
                        var dt = new DataTable(); da.Fill(dt);
                        dgvEstudiantes.DataSource = dt;
                    }
                }
                if (dgvEstudiantes.Columns.Contains("IdEstudiante"))
                    dgvEstudiantes.Columns["IdEstudiante"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idEditando = 0; txtNombre.Clear(); txtApellido.Clear();
            txtCurso.Clear(); cmbSeccion.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Today; txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtCurso.Text))
                { MessageBox.Show("Completa Nombre, Apellido y Curso.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }

                using (var con = Conexion.Abrir())
                {
                    string sql = _idEditando == 0
                        ? "INSERT INTO Estudiantes (Nombre,Apellido,Curso,Seccion,FechaIngreso,Activo) VALUES(@n,@a,@c,@s,@f,1)"
                        : "UPDATE Estudiantes SET Nombre=@n,Apellido=@a,Curso=@c,Seccion=@s,FechaIngreso=@f WHERE IdEstudiante=@id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@a", txtApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@c", txtCurso.Text.Trim());
                        cmd.Parameters.AddWithValue("@s", cmbSeccion.Text);
                        cmd.Parameters.AddWithValue("@f", dtpFechaIngreso.Value.Date);
                        if (_idEditando != 0) cmd.Parameters.AddWithValue("@id", _idEditando);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(_idEditando == 0 ? "Estudiante registrado." : "Estudiante actualizado.","OK",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnNuevo_Click(null, null); CargarEstudiantes();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow == null) return;
            _idEditando      = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value);
            txtNombre.Text   = dgvEstudiantes.CurrentRow.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = dgvEstudiantes.CurrentRow.Cells["Apellido"].Value?.ToString();
            txtCurso.Text    = dgvEstudiantes.CurrentRow.Cells["Curso"].Value?.ToString();
            string sec = dgvEstudiantes.CurrentRow.Cells["Seccion"].Value?.ToString();
            cmbSeccion.Text = sec;
            if (dgvEstudiantes.CurrentRow.Cells["FechaIngreso"].Value != DBNull.Value)
                dtpFechaIngreso.Value = Convert.ToDateTime(dgvEstudiantes.CurrentRow.Cells["FechaIngreso"].Value);
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow == null) return;
            if (MessageBox.Show("¿Desactivar este estudiante?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes) return;
            try
            {
                int id = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value);
                using (var con = Conexion.Abrir())
                using (var cmd = new MySqlCommand("UPDATE Estudiantes SET Activo=0 WHERE IdEstudiante=@id", con))
                { cmd.Parameters.AddWithValue("@id", id); cmd.ExecuteNonQuery(); }
                CargarEstudiantes();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnBuscar_Click(object sender, EventArgs e) { CargarEstudiantes(txtBuscar.Text.Trim()); }
        private void txtBuscar_TextChanged(object sender, EventArgs e) { CargarEstudiantes(txtBuscar.Text.Trim()); }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
