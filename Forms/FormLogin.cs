using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormLogin : Form
    {
        private int _intentos = 0;
        private const int MAX_INTENTOS = 3;

        public FormLogin() { InitializeComponent(); }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "Bienvenido. Ingresa tus credenciales.";
            lblMensaje.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MostrarError("Por favor completa usuario y contraseña.");
                    return;
                }
                using (var con = Conexion.Abrir())
                {
                    string sql = @"SELECT u.IdUsuario, u.NombreCompleto, u.IdRol, r.NombreRol
                                   FROM   Usuarios u
                                   INNER  JOIN Roles r ON r.IdRol = u.IdRol
                                   WHERE  u.Username = @user AND u.Password = @pass AND u.Activo = 1";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                Sesion.IdUsuario      = dr.GetInt32("IdUsuario");
                                Sesion.NombreCompleto = dr.GetString("NombreCompleto");
                                Sesion.IdRol          = dr.GetInt32("IdRol");
                                Sesion.NombreRol      = dr.GetString("NombreRol");
                                this.Hide();
                                new FormMenu().Show();
                            }
                            else
                            {
                                _intentos++;
                                int restantes = MAX_INTENTOS - _intentos;
                                if (restantes > 0)
                                    MostrarError($"Credenciales incorrectas. Intentos restantes: {restantes}");
                                else
                                {
                                    MostrarError("Demasiados intentos. Acceso bloqueado.");
                                    btnIniciarSesion.Enabled = false;
                                }
                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) { Application.Exit(); }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnIniciarSesion_Click(sender, e);
        }

        private void MostrarError(string m)
        {
            lblMensaje.Text = "⚠ " + m;
            lblMensaje.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
        }
    }
}
