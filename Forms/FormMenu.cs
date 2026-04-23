using System;
using System.Windows.Forms;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu() { InitializeComponent(); }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = $"Bienvenido: {Sesion.NombreCompleto}  |  Rol: {Sesion.NombreRol}";
            btnUsuarios.Visible = Sesion.EsAdmin;
            tsLabel.Text = $"  Usuario: {Sesion.NombreCompleto}  |  {DateTime.Now:dd/MM/yyyy HH:mm}";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)      { AbrirForm(new FormUsuarios()); }
        private void btnEstudiantes_Click(object sender, EventArgs e)   { AbrirForm(new FormEstudiantes()); }
        private void btnContactos_Click(object sender, EventArgs e)     { AbrirForm(new FormContactos()); }
        private void btnPagos_Click(object sender, EventArgs e)         { AbrirForm(new FormPagos()); }
        private void btnFacturas_Click(object sender, EventArgs e)      { AbrirForm(new FormFacturas()); }
        private void btnConsultaEst_Click(object sender, EventArgs e)   { AbrirForm(new FormConsultaEst()); }
        private void btnConsultaPagos_Click(object sender, EventArgs e) { AbrirForm(new FormConsultaPagos()); }
        private void btnReportes_Click(object sender, EventArgs e)      { AbrirForm(new FormReportes()); }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sesion.Limpiar();
                new FormLogin().Show();
                this.Close();
            }
        }

        private void AbrirForm(Form f)
        {
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
