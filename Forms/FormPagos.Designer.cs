namespace accountableSystem.Forms
{
    partial class FormPagos
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
            this.txtConcepto    = new System.Windows.Forms.TextBox();
            this.lblConcepto    = new System.Windows.Forms.Label();
            this.txtMonto       = new System.Windows.Forms.TextBox();
            this.lblMonto       = new System.Windows.Forms.Label();
            this.cmbMes         = new System.Windows.Forms.ComboBox();
            this.lblMes         = new System.Windows.Forms.Label();
            this.dtpFecha       = new System.Windows.Forms.DateTimePicker();
            this.lblFecha       = new System.Windows.Forms.Label();
            this.cmbEstudiante  = new System.Windows.Forms.ComboBox();
            this.lblEstudiante  = new System.Windows.Forms.Label();
            this.dgvPagos       = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 148, 136);
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
            this.lblHeader.Text      = "Registro de Pagos";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // splitMain
            this.splitMain.Dock             = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Name             = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.grpDatos);
            this.splitMain.Panel1.Padding   = new System.Windows.Forms.Padding(10);
            this.splitMain.Panel2.Controls.Add(this.dgvPagos);
            this.splitMain.Panel2.Padding   = new System.Windows.Forms.Padding(10);
            this.splitMain.SplitterDistance = 310;
            this.splitMain.TabIndex         = 1;

            // grpDatos
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.txtConcepto);
            this.grpDatos.Controls.Add(this.lblConcepto);
            this.grpDatos.Controls.Add(this.txtMonto);
            this.grpDatos.Controls.Add(this.lblMonto);
            this.grpDatos.Controls.Add(this.cmbMes);
            this.grpDatos.Controls.Add(this.lblMes);
            this.grpDatos.Controls.Add(this.dtpFecha);
            this.grpDatos.Controls.Add(this.lblFecha);
            this.grpDatos.Controls.Add(this.cmbEstudiante);
            this.grpDatos.Controls.Add(this.lblEstudiante);
            this.grpDatos.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.grpDatos.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.grpDatos.Name      = "grpDatos";
            this.grpDatos.TabIndex  = 0;
            this.grpDatos.Text      = "Registrar Pago";

            // lblEstudiante
            this.lblEstudiante.AutoSize  = true;
            this.lblEstudiante.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstudiante.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblEstudiante.Location  = new System.Drawing.Point(10, 28);
            this.lblEstudiante.Name      = "lblEstudiante";
            this.lblEstudiante.TabIndex  = 0;
            this.lblEstudiante.Text      = "Estudiante";

            // cmbEstudiante
            this.cmbEstudiante.DropDownStyle             = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.Location                  = new System.Drawing.Point(10, 46);
            this.cmbEstudiante.Name                      = "cmbEstudiante";
            this.cmbEstudiante.Size                      = new System.Drawing.Size(270, 26);
            this.cmbEstudiante.TabIndex                  = 1;
            this.cmbEstudiante.SelectedIndexChanged     += new System.EventHandler(this.cmbEstudiante_SelectedIndexChanged);

            // lblFecha
            this.lblFecha.AutoSize  = true;
            this.lblFecha.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblFecha.Location  = new System.Drawing.Point(10, 82);
            this.lblFecha.Name      = "lblFecha";
            this.lblFecha.TabIndex  = 2;
            this.lblFecha.Text      = "Fecha del Pago";

            // dtpFecha
            this.dtpFecha.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(10, 100);
            this.dtpFecha.Name     = "dtpFecha";
            this.dtpFecha.Size     = new System.Drawing.Size(270, 26);
            this.dtpFecha.TabIndex = 3;

            // lblMes
            this.lblMes.AutoSize  = true;
            this.lblMes.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblMes.Location  = new System.Drawing.Point(10, 136);
            this.lblMes.Name      = "lblMes";
            this.lblMes.TabIndex  = 4;
            this.lblMes.Text      = "Mes que Paga";

            // cmbMes
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Items.AddRange(new object[] {
                "Enero","Febrero","Marzo","Abril","Mayo","Junio",
                "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"});
            this.cmbMes.Location      = new System.Drawing.Point(10, 154);
            this.cmbMes.Name          = "cmbMes";
            this.cmbMes.Size          = new System.Drawing.Size(270, 26);
            this.cmbMes.TabIndex      = 5;

            // lblMonto
            this.lblMonto.AutoSize  = true;
            this.lblMonto.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblMonto.Location  = new System.Drawing.Point(10, 190);
            this.lblMonto.Name      = "lblMonto";
            this.lblMonto.TabIndex  = 6;
            this.lblMonto.Text      = "Monto (RD$)";

            // txtMonto
            this.txtMonto.BackColor   = System.Drawing.Color.White;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Location    = new System.Drawing.Point(10, 208);
            this.txtMonto.Name        = "txtMonto";
            this.txtMonto.Size        = new System.Drawing.Size(270, 26);
            this.txtMonto.TabIndex    = 7;

            // lblConcepto
            this.lblConcepto.AutoSize  = true;
            this.lblConcepto.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblConcepto.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblConcepto.Location  = new System.Drawing.Point(10, 244);
            this.lblConcepto.Name      = "lblConcepto";
            this.lblConcepto.TabIndex  = 8;
            this.lblConcepto.Text      = "Concepto";

            // txtConcepto
            this.txtConcepto.BackColor   = System.Drawing.Color.White;
            this.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConcepto.Location    = new System.Drawing.Point(10, 262);
            this.txtConcepto.Name        = "txtConcepto";
            this.txtConcepto.Size        = new System.Drawing.Size(270, 26);
            this.txtConcepto.TabIndex    = 9;

            // btnGuardar
            this.btnGuardar.BackColor                 = System.Drawing.Color.FromArgb(13, 148, 136);
            this.btnGuardar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor                 = System.Drawing.Color.White;
            this.btnGuardar.Location                  = new System.Drawing.Point(10, 306);
            this.btnGuardar.Name                      = "btnGuardar";
            this.btnGuardar.Size                      = new System.Drawing.Size(130, 34);
            this.btnGuardar.TabIndex                  = 10;
            this.btnGuardar.Text                      = "Guardar Pago";
            this.btnGuardar.Click                    += new System.EventHandler(this.btnGuardar_Click);

            // btnLimpiar
            this.btnLimpiar.BackColor                 = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnLimpiar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor                 = System.Drawing.Color.White;
            this.btnLimpiar.Location                  = new System.Drawing.Point(150, 306);
            this.btnLimpiar.Name                      = "btnLimpiar";
            this.btnLimpiar.Size                      = new System.Drawing.Size(130, 34);
            this.btnLimpiar.TabIndex                  = 11;
            this.btnLimpiar.Text                      = "Limpiar";
            this.btnLimpiar.Click                    += new System.EventHandler(this.btnLimpiar_Click);

            // dgvPagos
            this.dgvPagos.AllowUserToAddRows                      = false;
            this.dgvPagos.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvPagos.BorderStyle                             = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 148, 136);
            this.dgvPagos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPagos.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvPagos.Dock                                    = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagos.EnableHeadersVisualStyles               = false;
            this.dgvPagos.Name                                    = "dgvPagos";
            this.dgvPagos.ReadOnly                                = true;
            this.dgvPagos.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.TabIndex                                = 0;

            // FormPagos
            this.BackColor     = System.Drawing.Color.FromArgb(248, 250, 255);
            this.ClientSize    = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlHeader);
            this.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.Name          = "FormPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Registro de Pagos";
            this.Load         += new System.EventHandler(this.FormPagos_Load);

            this.pnlHeader.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel          pnlHeader;
        private System.Windows.Forms.Label          lblHeader;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox       grpDatos;
        private System.Windows.Forms.Label          lblEstudiante, lblFecha, lblMes, lblMonto, lblConcepto;
        private System.Windows.Forms.ComboBox       cmbEstudiante, cmbMes;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox        txtMonto, txtConcepto;
        private System.Windows.Forms.Button         btnGuardar, btnLimpiar;
        private System.Windows.Forms.DataGridView   dgvPagos;
    }
}
