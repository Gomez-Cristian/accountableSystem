namespace accountableSystem.Forms
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblTitulo        = new System.Windows.Forms.Label();
            this.lblSubtitulo     = new System.Windows.Forms.Label();
            this.pnlBody          = new System.Windows.Forms.Panel();
            this.lblIcono         = new System.Windows.Forms.Label();
            this.lblAppName       = new System.Windows.Forms.Label();
            this.lblAppDesc       = new System.Windows.Forms.Label();
            this.lblUser          = new System.Windows.Forms.Label();
            this.txtUsuario       = new System.Windows.Forms.TextBox();
            this.lblPass          = new System.Windows.Forms.Label();
            this.txtPassword      = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnSalir         = new System.Windows.Forms.Button();
            this.lblMensaje       = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height   = 80;
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location  = new System.Drawing.Point(0, 12);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(440, 30);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "accountableSystem";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitulo
            this.lblSubtitulo.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblSubtitulo.Location  = new System.Drawing.Point(0, 46);
            this.lblSubtitulo.Name      = "lblSubtitulo";
            this.lblSubtitulo.Size      = new System.Drawing.Size(440, 20);
            this.lblSubtitulo.TabIndex  = 1;
            this.lblSubtitulo.Text      = "Sistema de Control de Pagos Escolares";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlBody
            this.pnlBody.BackColor   = System.Drawing.Color.White;
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.lblMensaje);
            this.pnlBody.Controls.Add(this.btnSalir);
            this.pnlBody.Controls.Add(this.btnIniciarSesion);
            this.pnlBody.Controls.Add(this.txtPassword);
            this.pnlBody.Controls.Add(this.lblPass);
            this.pnlBody.Controls.Add(this.txtUsuario);
            this.pnlBody.Controls.Add(this.lblUser);
            this.pnlBody.Controls.Add(this.lblAppDesc);
            this.pnlBody.Controls.Add(this.lblAppName);
            this.pnlBody.Controls.Add(this.lblIcono);
            this.pnlBody.Location    = new System.Drawing.Point(60, 100);
            this.pnlBody.Name        = "pnlBody";
            this.pnlBody.Size        = new System.Drawing.Size(320, 400);
            this.pnlBody.TabIndex    = 1;

            // lblIcono
            this.lblIcono.Font      = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lblIcono.Location  = new System.Drawing.Point(0, 16);
            this.lblIcono.Name      = "lblIcono";
            this.lblIcono.Size      = new System.Drawing.Size(318, 46);
            this.lblIcono.TabIndex  = 0;
            this.lblIcono.Text      = "🎓";
            this.lblIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblAppName
            this.lblAppName.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblAppName.Location  = new System.Drawing.Point(0, 66);
            this.lblAppName.Name      = "lblAppName";
            this.lblAppName.Size      = new System.Drawing.Size(318, 22);
            this.lblAppName.TabIndex  = 1;
            this.lblAppName.Text      = "accountableSystem";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblAppDesc
            this.lblAppDesc.Font      = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAppDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblAppDesc.Location  = new System.Drawing.Point(0, 90);
            this.lblAppDesc.Name      = "lblAppDesc";
            this.lblAppDesc.Size      = new System.Drawing.Size(318, 16);
            this.lblAppDesc.TabIndex  = 2;
            this.lblAppDesc.Text      = "Politécnico FARDM — Ing. Cristian Gómez";
            this.lblAppDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUser
            this.lblUser.AutoSize  = true;
            this.lblUser.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblUser.Location  = new System.Drawing.Point(20, 118);
            this.lblUser.Name      = "lblUser";
            this.lblUser.TabIndex  = 3;
            this.lblUser.Text      = "Usuario";

            // txtUsuario
            this.txtUsuario.BackColor   = System.Drawing.Color.FromArgb(248, 250, 255);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location    = new System.Drawing.Point(20, 137);
            this.txtUsuario.Name        = "txtUsuario";
            this.txtUsuario.Size        = new System.Drawing.Size(278, 26);
            this.txtUsuario.TabIndex    = 4;

            // lblPass
            this.lblPass.AutoSize  = true;
            this.lblPass.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblPass.Location  = new System.Drawing.Point(20, 175);
            this.lblPass.Name      = "lblPass";
            this.lblPass.TabIndex  = 5;
            this.lblPass.Text      = "Contraseña";

            // txtPassword
            this.txtPassword.BackColor    = System.Drawing.Color.FromArgb(248, 250, 255);
            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location     = new System.Drawing.Point(20, 194);
            this.txtPassword.Name         = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size         = new System.Drawing.Size(278, 26);
            this.txtPassword.TabIndex     = 6;
            this.txtPassword.KeyDown     += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);

            // btnIniciarSesion
            this.btnIniciarSesion.BackColor                 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnIniciarSesion.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor                 = System.Drawing.Color.White;
            this.btnIniciarSesion.Location                  = new System.Drawing.Point(20, 242);
            this.btnIniciarSesion.Name                      = "btnIniciarSesion";
            this.btnIniciarSesion.Size                      = new System.Drawing.Size(278, 38);
            this.btnIniciarSesion.TabIndex                  = 7;
            this.btnIniciarSesion.Text                      = "Iniciar Sesión";
            this.btnIniciarSesion.Click                    += new System.EventHandler(this.btnIniciarSesion_Click);

            // btnSalir
            this.btnSalir.BackColor                  = System.Drawing.Color.FromArgb(229, 231, 235);
            this.btnSalir.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnSalir.Font                       = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalir.ForeColor                  = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnSalir.Location                   = new System.Drawing.Point(20, 290);
            this.btnSalir.Name                       = "btnSalir";
            this.btnSalir.Size                       = new System.Drawing.Size(278, 34);
            this.btnSalir.TabIndex                   = 8;
            this.btnSalir.Text                       = "Salir";
            this.btnSalir.Click                     += new System.EventHandler(this.btnSalir_Click);

            // lblMensaje
            this.lblMensaje.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMensaje.Location  = new System.Drawing.Point(14, 336);
            this.lblMensaje.Name      = "lblMensaje";
            this.lblMensaje.Size      = new System.Drawing.Size(290, 50);
            this.lblMensaje.TabIndex  = 9;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormLogin
            this.BackColor       = System.Drawing.Color.FromArgb(248, 250, 255);
            this.ClientSize      = new System.Drawing.Size(440, 540);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormLogin";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "accountableSystem — Login";
            this.Load           += new System.EventHandler(this.FormLogin_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel   pnlHeader, pnlBody;
        private System.Windows.Forms.Label   lblTitulo, lblSubtitulo, lblIcono, lblAppName, lblAppDesc;
        private System.Windows.Forms.Label   lblUser, lblPass, lblMensaje;
        private System.Windows.Forms.TextBox txtUsuario, txtPassword;
        private System.Windows.Forms.Button  btnIniciarSesion, btnSalir;
    }
}
