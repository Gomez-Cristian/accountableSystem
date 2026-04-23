namespace accountableSystem.Forms
{
    partial class FormFacturas
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
            this.lblHeader        = new System.Windows.Forms.Label();
            this.pnlTop           = new System.Windows.Forms.Panel();
            this.btnAnular        = new System.Windows.Forms.Button();
            this.btnVerFacturas   = new System.Windows.Forms.Button();
            this.cmbEstudiante    = new System.Windows.Forms.ComboBox();
            this.lblEst           = new System.Windows.Forms.Label();
            this.dgvFacturas      = new System.Windows.Forms.DataGridView();
            this.lblTotalFacturado = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(194, 65, 12);
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
            this.lblHeader.Text      = "Consulta de Facturas";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnAnular);
            this.pnlTop.Controls.Add(this.btnVerFacturas);
            this.pnlTop.Controls.Add(this.cmbEstudiante);
            this.pnlTop.Controls.Add(this.lblEst);
            this.pnlTop.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height    = 56;
            this.pnlTop.Name      = "pnlTop";
            this.pnlTop.Padding   = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pnlTop.TabIndex  = 1;

            // lblEst
            this.lblEst.AutoSize  = true;
            this.lblEst.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEst.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblEst.Location  = new System.Drawing.Point(10, 16);
            this.lblEst.Name      = "lblEst";
            this.lblEst.TabIndex  = 0;
            this.lblEst.Text      = "Estudiante:";

            // cmbEstudiante
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.Location      = new System.Drawing.Point(100, 12);
            this.cmbEstudiante.Name          = "cmbEstudiante";
            this.cmbEstudiante.Size          = new System.Drawing.Size(300, 26);
            this.cmbEstudiante.TabIndex      = 1;

            // btnVerFacturas
            this.btnVerFacturas.BackColor                 = System.Drawing.Color.FromArgb(194, 65, 12);
            this.btnVerFacturas.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnVerFacturas.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFacturas.FlatAppearance.BorderSize = 0;
            this.btnVerFacturas.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnVerFacturas.ForeColor                 = System.Drawing.Color.White;
            this.btnVerFacturas.Location                  = new System.Drawing.Point(410, 12);
            this.btnVerFacturas.Name                      = "btnVerFacturas";
            this.btnVerFacturas.Size                      = new System.Drawing.Size(120, 28);
            this.btnVerFacturas.TabIndex                  = 2;
            this.btnVerFacturas.Text                      = "Ver Facturas";
            this.btnVerFacturas.Click                    += new System.EventHandler(this.btnVerFacturas_Click);

            // btnAnular
            this.btnAnular.BackColor                 = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnAnular.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnAnular.ForeColor                 = System.Drawing.Color.White;
            this.btnAnular.Location                  = new System.Drawing.Point(540, 12);
            this.btnAnular.Name                      = "btnAnular";
            this.btnAnular.Size                      = new System.Drawing.Size(120, 28);
            this.btnAnular.TabIndex                  = 3;
            this.btnAnular.Text                      = "Anular";
            this.btnAnular.Click                    += new System.EventHandler(this.btnAnular_Click);

            // dgvFacturas
            this.dgvFacturas.AllowUserToAddRows                      = false;
            this.dgvFacturas.Anchor                                  = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Bottom));
            this.dgvFacturas.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvFacturas.BorderStyle                             = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(194, 65, 12);
            this.dgvFacturas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvFacturas.EnableHeadersVisualStyles               = false;
            this.dgvFacturas.Location                                = new System.Drawing.Point(10, 116);
            this.dgvFacturas.Name                                    = "dgvFacturas";
            this.dgvFacturas.ReadOnly                                = true;
            this.dgvFacturas.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size                                    = new System.Drawing.Size(830, 360);
            this.dgvFacturas.TabIndex                                = 2;

            // lblTotalFacturado
            this.lblTotalFacturado.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalFacturado.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.lblTotalFacturado.Location  = new System.Drawing.Point(10, 486);
            this.lblTotalFacturado.Name      = "lblTotalFacturado";
            this.lblTotalFacturado.Size      = new System.Drawing.Size(500, 22);
            this.lblTotalFacturado.TabIndex  = 3;

            // FormFacturas
            this.BackColor     = System.Drawing.Color.FromArgb(248, 250, 255);
            this.ClientSize    = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.lblTotalFacturado);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.Name          = "FormFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Facturas";
            this.Load         += new System.EventHandler(this.FormFacturas_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel        pnlHeader, pnlTop;
        private System.Windows.Forms.Label        lblHeader, lblEst, lblTotalFacturado;
        private System.Windows.Forms.ComboBox     cmbEstudiante;
        private System.Windows.Forms.Button       btnVerFacturas, btnAnular;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}
