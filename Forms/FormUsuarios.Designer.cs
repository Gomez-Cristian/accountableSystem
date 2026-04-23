namespace accountableSystem.Forms
{
    partial class FormUsuarios
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
            this.pnlHeader    = new System.Windows.Forms.Panel();
            this.lblHeader    = new System.Windows.Forms.Label();
            this.splitMain    = new System.Windows.Forms.SplitContainer();
            this.grpDatos     = new System.Windows.Forms.GroupBox();
            this.btnDesactivar= new System.Windows.Forms.Button();
            this.btnEditar    = new System.Windows.Forms.Button();
            this.btnGuardar   = new System.Windows.Forms.Button();
            this.btnNuevo     = new System.Windows.Forms.Button();
            this.cmbRol       = new System.Windows.Forms.ComboBox();
            this.lblRol       = new System.Windows.Forms.Label();
            this.txtPassword  = new System.Windows.Forms.TextBox();
            this.lblPassword  = new System.Windows.Forms.Label();
            this.txtUsername  = new System.Windows.Forms.TextBox();
            this.lblUsername  = new System.Windows.Forms.Label();
            this.txtNombre    = new System.Windows.Forms.TextBox();
            this.lblNombre    = new System.Windows.Forms.Label();
            this.dgvUsuarios  = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height   = 50;
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.TabIndex = 0;

            // lblHeader
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Registro de Usuarios (Solo Administrador)";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // splitMain
            this.splitMain.Dock             = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Name             = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.grpDatos);
            this.splitMain.Panel1.Padding   = new System.Windows.Forms.Padding(10);
            this.splitMain.Panel2.Controls.Add(this.dgvUsuarios);
            this.splitMain.Panel2.Padding   = new System.Windows.Forms.Padding(10);
            this.splitMain.SplitterDistance = 290;
            this.splitMain.TabIndex         = 1;

            // grpDatos
            this.grpDatos.Controls.Add(this.btnDesactivar);
            this.grpDatos.Controls.Add(this.btnEditar);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.btnNuevo);
            this.grpDatos.Controls.Add(this.cmbRol);
            this.grpDatos.Controls.Add(this.lblRol);
            this.grpDatos.Controls.Add(this.txtPassword);
            this.grpDatos.Controls.Add(this.lblPassword);
            this.grpDatos.Controls.Add(this.txtUsername);
            this.grpDatos.Controls.Add(this.lblUsername);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.grpDatos.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.grpDatos.Name      = "grpDatos";
            this.grpDatos.TabIndex  = 0;
            this.grpDatos.Text      = "Datos del Usuario";

            // lblNombre
            this.lblNombre.AutoSize  = true;
            this.lblNombre.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblNombre.Location  = new System.Drawing.Point(10, 30);
            this.lblNombre.Name      = "lblNombre";
            this.lblNombre.TabIndex  = 0;
            this.lblNombre.Text      = "Nombre Completo";

            // txtNombre
            this.txtNombre.BackColor   = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location    = new System.Drawing.Point(10, 48);
            this.txtNombre.Name        = "txtNombre";
            this.txtNombre.Size        = new System.Drawing.Size(250, 26);
            this.txtNombre.TabIndex    = 1;

            // lblUsername
            this.lblUsername.AutoSize  = true;
            this.lblUsername.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblUsername.Location  = new System.Drawing.Point(10, 84);
            this.lblUsername.Name      = "lblUsername";
            this.lblUsername.TabIndex  = 2;
            this.lblUsername.Text      = "Username";

            // txtUsername
            this.txtUsername.BackColor   = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location    = new System.Drawing.Point(10, 102);
            this.txtUsername.Name        = "txtUsername";
            this.txtUsername.Size        = new System.Drawing.Size(250, 26);
            this.txtUsername.TabIndex    = 3;

            // lblPassword
            this.lblPassword.AutoSize  = true;
            this.lblPassword.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblPassword.Location  = new System.Drawing.Point(10, 138);
            this.lblPassword.Name      = "lblPassword";
            this.lblPassword.TabIndex  = 4;
            this.lblPassword.Text      = "Contraseña";

            // txtPassword
            this.txtPassword.BackColor    = System.Drawing.Color.White;
            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location     = new System.Drawing.Point(10, 156);
            this.txtPassword.Name         = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size         = new System.Drawing.Size(250, 26);
            this.txtPassword.TabIndex     = 5;

            // lblRol
            this.lblRol.AutoSize  = true;
            this.lblRol.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblRol.Location  = new System.Drawing.Point(10, 192);
            this.lblRol.Name      = "lblRol";
            this.lblRol.TabIndex  = 6;
            this.lblRol.Text      = "Rol";

            // cmbRol
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Location      = new System.Drawing.Point(10, 210);
            this.cmbRol.Name          = "cmbRol";
            this.cmbRol.Size          = new System.Drawing.Size(250, 26);
            this.cmbRol.TabIndex      = 7;

            // btnNuevo
            this.btnNuevo.BackColor                 = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnNuevo.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor                 = System.Drawing.Color.White;
            this.btnNuevo.Location                  = new System.Drawing.Point(10, 256);
            this.btnNuevo.Name                      = "btnNuevo";
            this.btnNuevo.Size                      = new System.Drawing.Size(120, 30);
            this.btnNuevo.TabIndex                  = 8;
            this.btnNuevo.Text                      = "Nuevo";
            this.btnNuevo.Click                    += new System.EventHandler(this.btnNuevo_Click);

            // btnGuardar
            this.btnGuardar.BackColor                 = System.Drawing.Color.FromArgb(22, 101, 52);
            this.btnGuardar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor                 = System.Drawing.Color.White;
            this.btnGuardar.Location                  = new System.Drawing.Point(140, 256);
            this.btnGuardar.Name                      = "btnGuardar";
            this.btnGuardar.Size                      = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex                  = 9;
            this.btnGuardar.Text                      = "Guardar";
            this.btnGuardar.Click                    += new System.EventHandler(this.btnGuardar_Click);

            // btnEditar
            this.btnEditar.BackColor                 = System.Drawing.Color.FromArgb(13, 148, 136);
            this.btnEditar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor                 = System.Drawing.Color.White;
            this.btnEditar.Location                  = new System.Drawing.Point(10, 296);
            this.btnEditar.Name                      = "btnEditar";
            this.btnEditar.Size                      = new System.Drawing.Size(120, 30);
            this.btnEditar.TabIndex                  = 10;
            this.btnEditar.Text                      = "Editar";
            this.btnEditar.Click                    += new System.EventHandler(this.btnEditar_Click);

            // btnDesactivar
            this.btnDesactivar.BackColor                 = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnDesactivar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnDesactivar.ForeColor                 = System.Drawing.Color.White;
            this.btnDesactivar.Location                  = new System.Drawing.Point(140, 296);
            this.btnDesactivar.Name                      = "btnDesactivar";
            this.btnDesactivar.Size                      = new System.Drawing.Size(120, 30);
            this.btnDesactivar.TabIndex                  = 11;
            this.btnDesactivar.Text                      = "Desactivar";
            this.btnDesactivar.Click                    += new System.EventHandler(this.btnDesactivar_Click);

            // dgvUsuarios
            this.dgvUsuarios.AllowUserToAddRows                      = false;
            this.dgvUsuarios.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle                             = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvUsuarios.Dock                                    = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles               = false;
            this.dgvUsuarios.Name                                    = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly                                = true;
            this.dgvUsuarios.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.TabIndex                                = 0;

            // FormUsuarios
            this.BackColor     = System.Drawing.Color.FromArgb(248, 250, 255);
            this.ClientSize    = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlHeader);
            this.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.Name          = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Registro de Usuarios";
            this.Load         += new System.EventHandler(this.FormUsuarios_Load);

            this.pnlHeader.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel          pnlHeader;
        private System.Windows.Forms.Label          lblHeader;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox       grpDatos;
        private System.Windows.Forms.Label          lblNombre, lblUsername, lblPassword, lblRol;
        private System.Windows.Forms.TextBox        txtNombre, txtUsername, txtPassword;
        private System.Windows.Forms.ComboBox       cmbRol;
        private System.Windows.Forms.Button         btnNuevo, btnGuardar, btnEditar, btnDesactivar;
        private System.Windows.Forms.DataGridView   dgvUsuarios;
    }
}
