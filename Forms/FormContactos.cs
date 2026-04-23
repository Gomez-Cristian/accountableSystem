using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormContactos : Form
    {
        private int _idEditando = 0;
        public FormContactos() { InitializeComponent(); }

        private void FormContactos_Load(object sender, EventArgs e) { CargarEstudiantes(); CargarContactos(); }

        private void CargarEstudiantes()
        {
            try
            {
                using (var con = Conexion.Abrir())
                using (var da = new MySqlDataAdapter(
                    "SELECT IdEstudiante, CONCAT(Nombre,' ',Apellido,' - ',Curso,Seccion) AS NombreCompleto FROM Estudiantes WHERE Activo=1 ORDER BY Apellido", con))
                {
                    var dt = new DataTable(); da.Fill(dt);
                    cmbEstudiante.DataSource = dt;
                    cmbEstudiante.DisplayMember = "NombreCompleto";
                    cmbEstudiante.ValueMember   = "IdEstudiante";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void CargarContactos()
        {
            try
            {
                using (var con = Conexion.Abrir())
                {
                    string sql = @"SELECT c.IdContacto, CONCAT(e.Nombre,' ',e.Apellido) AS Estudiante,
                                          c.NombreTutor, c.Parentesco, c.Telefono, c.Correo
                                   FROM   Contactos c
                                   INNER  JOIN Estudiantes e ON e.IdEstudiante = c.IdEstudiante
                                   ORDER  BY e.Apellido";
                    using (var da = new MySqlDataAdapter(sql, con))
                    { var dt=new DataTable(); da.Fill(dt); dgvContactos.DataSource=dt; }
                }
                if (dgvContactos.Columns.Contains("IdContacto")) dgvContactos.Columns["IdContacto"].Visible=false;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstudiante.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtNombreTutor.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text))
                { MessageBox.Show("Completa Estudiante, Nombre del Tutor y Teléfono.","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning); return; }

                int idEst = Convert.ToInt32(cmbEstudiante.SelectedValue);
                using (var con = Conexion.Abrir())
                {
                    string sql = _idEditando == 0
                        ? @"INSERT INTO Contactos (IdEstudiante,NombreTutor,Parentesco,Telefono,Correo)
                             VALUES(@e,@n,@p,@t,@c)"
                        : @"UPDATE Contactos SET IdEstudiante=@e,NombreTutor=@n,Parentesco=@p,Telefono=@t,Correo=@c
                             WHERE IdContacto=@id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@e", idEst);
                        cmd.Parameters.AddWithValue("@n", txtNombreTutor.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", cmbParentesco.Text);
                        cmd.Parameters.AddWithValue("@t", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@c", string.IsNullOrWhiteSpace(txtCorreo.Text) ? (object)DBNull.Value : txtCorreo.Text.Trim());
                        if (_idEditando != 0) cmd.Parameters.AddWithValue("@id", _idEditando);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Contacto guardado correctamente.","OK",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnLimpiar_Click(null,null); CargarContactos();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _idEditando = 0;
            if (cmbEstudiante.Items.Count > 0) cmbEstudiante.SelectedIndex = 0;
            txtNombreTutor.Clear(); cmbParentesco.SelectedIndex = 0;
            txtTelefono.Clear(); txtCorreo.Clear();
        }

        private void dgvContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvContactos.Rows[e.RowIndex];
            _idEditando = Convert.ToInt32(row.Cells["IdContacto"].Value);
            txtNombreTutor.Text = row.Cells["NombreTutor"].Value?.ToString();
            cmbParentesco.Text  = row.Cells["Parentesco"].Value?.ToString();
            txtTelefono.Text    = row.Cells["Telefono"].Value?.ToString();
            txtCorreo.Text      = row.Cells["Correo"].Value?.ToString();
        }
    }
}
