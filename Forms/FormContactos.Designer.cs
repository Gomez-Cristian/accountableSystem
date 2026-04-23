namespace accountableSystem.Forms
{
    partial class FormContactos
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
            this.pnlHeader      = new System.Windows.Forms.Panel();
            this.lblHeader      = new System.Windows.Forms.Label();
            this.splitMain      = new System.Windows.Forms.SplitContainer();
            this.grpDatos       = new System.Windows.Forms.GroupBox();
            this.btnLimpiar     = new System.Windows.Forms.Button();
            this.btnGuardar     = new System.Windows.Forms.Button();
            this.txtCorreo      = new System.Windows.Forms.TextBox();
            this.lblCorreo      = new System.Windows.Forms.Label();
            this.txtTelefono    = new System.Windows.Forms.TextBox();
            this.lblTelefono    = new System.Windows.Forms.Label();
            this.cmbParentesco  = new System.Windows.Forms.ComboBox();
            this.lblParentesco  = new System.Windows.Forms.Label();
            this.txtNombreTutor = new System.Windows.Forms.TextBox();
            this.lblNombreTutor = new System.Windows.Forms.Label();
            this.cmbEstudiante  = new System.Windows.Forms.ComboBox();
            this.lblEstudiante  = new System.Windows.Forms.Label();
            this.dgvContactos   = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
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
            this.lblHeader.Text      = "Registro de Contactos (Tutores/Padres)";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // splitMain
            this.splitMain.Dock             = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Name             = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.grpDatos);
            this.splitMain.Panel1.Padding   = new System.Windows.Forms.Padding(10);
            this.splitMain.Panel2.Controls.Add(this.dgvContactos);
            this.splitMain.Panel2.Padding   = new System.Windows.Forms.Padding(10);
            this.splitMain.SplitterDistance = 310;
            this.splitMain.TabIndex         = 1;

            // grpDatos
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.txtCorreo);
            this.grpDatos.Controls.Add(this.lblCorreo);
            this.grpDatos.Controls.Add(this.txtTelefono);
            this.grpDatos.Controls.Add(this.lblTelefono);
            this.grpDatos.Controls.Add(this.cmbParentesco);
            this.grpDatos.Controls.Add(this.lblParentesco);
            this.grpDatos.Controls.Add(this.txtNombreTutor);
            this.grpDatos.Controls.Add(this.lblNombreTutor);
            this.grpDatos.Controls.Add(this.cmbEstudiante);
            this.grpDatos.Controls.Add(this.lblEstudiante);
            this.grpDatos.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.grpDatos.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.grpDatos.Name      = "grpDatos";
            this.grpDatos.TabIndex  = 0;
            this.grpDatos.Text      = "Datos del Contacto";

            // lblEstudiante
            this.lblEstudiante.AutoSize  = true;
            this.lblEstudiante.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstudiante.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblEstudiante.Location  = new System.Drawing.Point(10, 28);
            this.lblEstudiante.Name      = "lblEstudiante";
            this.lblEstudiante.TabIndex  = 0;
            this.lblEstudiante.Text      = "Estudiante";

            // cmbEstudiante
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.Location      = new System.Drawing.Point(10, 46);
            this.cmbEstudiante.Name          = "cmbEstudiante";
            this.cmbEstudiante.Size          = new System.Drawing.Size(270, 26);
            this.cmbEstudiante.TabIndex      = 1;

            // lblNombreTutor
            this.lblNombreTutor.AutoSize  = true;
            this.lblNombreTutor.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreTutor.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblNombreTutor.Location  = new System.Drawing.Point(10, 82);
            this.lblNombreTutor.Name      = "lblNombreTutor";
            this.lblNombreTutor.TabIndex  = 2;
            this.lblNombreTutor.Text      = "Nombre del Tutor";

            // txtNombreTutor
            this.txtNombreTutor.BackColor   = System.Drawing.Color.White;
            this.txtNombreTutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreTutor.Location    = new System.Drawing.Point(10, 100);
            this.txtNombreTutor.Name        = "txtNombreTutor";
            this.txtNombreTutor.Size        = new System.Drawing.Size(270, 26);
            this.txtNombreTutor.TabIndex    = 3;

            // lblParentesco
            this.lblParentesco.AutoSize  = true;
            this.lblParentesco.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblParentesco.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblParentesco.Location  = new System.Drawing.Point(10, 136);
            this.lblParentesco.Name      = "lblParentesco";
            this.lblParentesco.TabIndex  = 4;
            this.lblParentesco.Text      = "Parentesco";

            // cmbParentesco
            this.cmbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentesco.Items.AddRange(new object[] { "Padre", "Madre", "Tutor", "Tio", "Abuelo", "Otro" });
            this.cmbParentesco.Location      = new System.Drawing.Point(10, 154);
            this.cmbParentesco.Name          = "cmbParentesco";
            this.cmbParentesco.SelectedIndex = 0;
            this.cmbParentesco.Size          = new System.Drawing.Size(270, 26);
            this.cmbParentesco.TabIndex      = 5;

            // lblTelefono
            this.lblTelefono.AutoSize  = true;
            this.lblTelefono.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblTelefono.Location  = new System.Drawing.Point(10, 190);
            this.lblTelefono.Name      = "lblTelefono";
            this.lblTelefono.TabIndex  = 6;
            this.lblTelefono.Text      = "Telefono";

            // txtTelefono
            this.txtTelefono.BackColor   = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location    = new System.Drawing.Point(10, 208);
            this.txtTelefono.Name        = "txtTelefono";
            this.txtTelefono.Size        = new System.Drawing.Size(270, 26);
            this.txtTelefono.TabIndex    = 7;

            // lblCorreo
            this.lblCorreo.AutoSize  = true;
            this.lblCorreo.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblCorreo.Location  = new System.Drawing.Point(10, 244);
            this.lblCorreo.Name      = "lblCorreo";
            this.lblCorreo.TabIndex  = 8;
            this.lblCorreo.Text      = "Correo (opcional)";

            // txtCorreo
            this.txtCorreo.BackColor   = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location    = new System.Drawing.Point(10, 262);
            this.txtCorreo.Name        = "txtCorreo";
            this.txtCorreo.Size        = new System.Drawing.Size(270, 26);
            this.txtCorreo.TabIndex    = 9;

            // btnGuardar
            this.btnGuardar.BackColor                 = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnGuardar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor                 = System.Drawing.Color.White;
            this.btnGuardar.Location                  = new System.Drawing.Point(10, 306);
            this.btnGuardar.Name                      = "btnGuardar";
            this.btnGuardar.Size                      = new System.Drawing.Size(130, 32);
            this.btnGuardar.TabIndex                  = 10;
            this.btnGuardar.Text                      = "Guardar";
            this.btnGuardar.Click                    += new System.EventHandler(this.btnGuardar_Click);

            // btnLimpiar
            this.btnLimpiar.BackColor                 = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnLimpiar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor                 = System.Drawing.Color.White;
            this.btnLimpiar.Location                  = new System.Drawing.Point(150, 306);
            this.btnLimpiar.Name                      = "btnLimpiar";
            this.btnLimpiar.Size                      = new System.Drawing.Size(130, 32);
            this.btnLimpiar.TabIndex                  = 11;
            this.btnLimpiar.Text                      = "Limpiar";
            this.btnLimpiar.Click                    += new System.EventHandler(this.btnLimpiar_Click);

            // dgvContactos
            this.dgvContactos.AllowUserToAddRows                      = false;
            this.dgvContactos.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvContactos.BorderStyle                             = System.Windows.Forms.BorderStyle.None;
            this.dgvContactos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 118, 110);
            this.dgvContactos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvContactos.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvContactos.Dock                                    = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactos.EnableHeadersVisualStyles               = false;
            this.dgvContactos.Name                                    = "dgvContactos";
            this.dgvContactos.ReadOnly                                = true;
            this.dgvContactos.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.TabIndex                                = 0;
            this.dgvContactos.CellDoubleClick                        += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellDoubleClick);

            // FormContactos
            this.BackColor     = System.Drawing.Color.FromArgb(248, 250, 255);
            this.ClientSize    = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlHeader);
            this.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.Name          = "FormContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Contactos / Tutores";
            this.Load         += new System.EventHandler(this.FormContactos_Load);

            this.pnlHeader.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel          pnlHeader;
        private System.Windows.Forms.Label          lblHeader;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox       grpDatos;
        private System.Windows.Forms.Label          lblEstudiante, lblNombreTutor, lblParentesco, lblTelefono, lblCorreo;
        private System.Windows.Forms.ComboBox       cmbEstudiante, cmbParentesco;
        private System.Windows.Forms.TextBox        txtNombreTutor, txtTelefono, txtCorreo;
        private System.Windows.Forms.Button         btnGuardar, btnLimpiar;
        private System.Windows.Forms.DataGridView   dgvContactos;
    }
}
