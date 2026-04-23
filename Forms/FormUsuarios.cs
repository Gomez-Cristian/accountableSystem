using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormUsuarios : Form
    {
        private int _idEditando = 0;

        public FormUsuarios() { InitializeComponent(); }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            if (!Sesion.EsAdmin)
            {
                MessageBox.Show("Solo el Administrador puede acceder a este módulo.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); return;
            }
            CargarRoles();
            CargarUsuarios();
        }

        private void CargarRoles()
        {
            try
            {
                using (var con = Conexion.Abrir())
                using (var cmd = new MySqlCommand("SELECT IdRol, NombreRol FROM Roles", con))
                using (var da  = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    cmbRol.DataSource    = dt;
                    cmbRol.DisplayMember = "NombreRol";
                    cmbRol.ValueMember   = "IdRol";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error cargando roles: " + ex.Message); }
        }

        private void CargarUsuarios()
        {
            try
            {
                using (var con = Conexion.Abrir())
                {
                    string sql = @"SELECT u.IdUsuario, u.NombreCompleto, u.Username,
                                          r.NombreRol,
                                          CASE WHEN u.Activo=1 THEN 'Activo' ELSE 'Inactivo' END AS Estado
                                   FROM   Usuarios u
                                   INNER  JOIN Roles r ON r.IdRol = u.IdRol
                                   ORDER  BY u.NombreCompleto";
                    using (var da = new MySqlDataAdapter(sql, con))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvUsuarios.DataSource = dt;
                    }
                }
                dgvUsuarios.Columns["IdUsuario"].Visible = false;
                if (dgvUsuarios.Columns.Contains("Estado"))
                    foreach (DataGridViewRow row in dgvUsuarios.Rows)
                    {
                        if (row.Cells["Estado"].Value?.ToString() == "Inactivo")
                            row.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                    }
            }
            catch (Exception ex) { MessageBox.Show("Error cargando usuarios: " + ex.Message); }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _idEditando = 0;
            txtNombre.Clear(); txtUsername.Clear(); txtPassword.Clear();
            if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Completa todos los campos.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                int idRol = (int)cmbRol.SelectedValue;
                using (var con = Conexion.Abrir())
                {
                    string sql = _idEditando == 0
                        ? "INSERT INTO Usuarios (NombreCompleto,Username,Password,IdRol,Activo) VALUES(@n,@u,@p,@r,1)"
                        : "UPDATE Usuarios SET NombreCompleto=@n, Username=@u, Password=@p, IdRol=@r WHERE IdUsuario=@id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@r", idRol);
                        if (_idEditando != 0) cmd.Parameters.AddWithValue("@id", _idEditando);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(_idEditando == 0 ? "Usuario creado correctamente." : "Usuario actualizado.",
                    "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNuevo_Click(null, null);
                CargarUsuarios();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar: " + ex.Message); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            _idEditando         = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            txtNombre.Text      = dgvUsuarios.CurrentRow.Cells["NombreCompleto"].Value?.ToString();
            txtUsername.Text    = dgvUsuarios.CurrentRow.Cells["Username"].Value?.ToString();
            txtPassword.Text    = "";
            string rol = dgvUsuarios.CurrentRow.Cells["NombreRol"].Value?.ToString();
            foreach (DataRowView item in cmbRol.Items)
                if (item["NombreRol"].ToString() == rol) { cmbRol.SelectedItem = item; break; }
            txtNombre.Focus();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            string user = dgvUsuarios.CurrentRow.Cells["Username"].Value?.ToString();
            if (user == "admin") { MessageBox.Show("No se puede desactivar al usuario admin."); return; }
            if (MessageBox.Show($"¿Desactivar a {user}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                using (var con = Conexion.Abrir())
                using (var cmd = new MySqlCommand("UPDATE Usuarios SET Activo=0 WHERE IdUsuario=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                CargarUsuarios();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
