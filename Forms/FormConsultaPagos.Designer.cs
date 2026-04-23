namespace accountableSystem.Forms
{
    partial class FormConsultaPagos
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
            this.pnlHeader     = new System.Windows.Forms.Panel();
            this.lblHeader     = new System.Windows.Forms.Label();
            this.pnlTop        = new System.Windows.Forms.Panel();
            this.btnExportar   = new System.Windows.Forms.Button();
            this.btnConsultar  = new System.Windows.Forms.Button();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.lblEst        = new System.Windows.Forms.Label();
            this.dgvPagos      = new System.Windows.Forms.DataGridView();
            this.lblMeses      = new System.Windows.Forms.Label();
            this.lblTotal      = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
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
            this.lblHeader.Text      = "Consulta de Pagos por Estudiante";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnExportar);
            this.pnlTop.Controls.Add(this.btnConsultar);
            this.pnlTop.Controls.Add(this.cmbEstudiante);
            this.pnlTop.Controls.Add(this.lblEst);
            this.pnlTop.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height    = 56;
            this.pnlTop.Name      = "pnlTop";
            this.pnlTop.TabIndex  = 1;

            // lblEst
            this.lblEst.AutoSize  = true;
            this.lblEst.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEst.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblEst.Location  = new System.Drawing.Point(10, 18);
            this.lblEst.Name      = "lblEst";
            this.lblEst.TabIndex  = 0;
            this.lblEst.Text      = "Estudiante:";

            // cmbEstudiante
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.Location      = new System.Drawing.Point(100, 14);
            this.cmbEstudiante.Name          = "cmbEstudiante";
            this.cmbEstudiante.Size          = new System.Drawing.Size(340, 26);
            this.cmbEstudiante.TabIndex      = 1;

            // btnConsultar
            this.btnConsultar.BackColor                 = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnConsultar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor                 = System.Drawing.Color.White;
            this.btnConsultar.Location                  = new System.Drawing.Point(450, 13);
            this.btnConsultar.Name                      = "btnConsultar";
            this.btnConsultar.Size                      = new System.Drawing.Size(120, 28);
            this.btnConsultar.TabIndex                  = 2;
            this.btnConsultar.Text                      = "Consultar";
            this.btnConsultar.Click                    += new System.EventHandler(this.btnConsultar_Click);

            // btnExportar
            this.btnExportar.BackColor                 = System.Drawing.Color.FromArgb(22, 101, 52);
            this.btnExportar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor                 = System.Drawing.Color.White;
            this.btnExportar.Location                  = new System.Drawing.Point(580, 13);
            this.btnExportar.Name                      = "btnExportar";
            this.btnExportar.Size                      = new System.Drawing.Size(120, 28);
            this.btnExportar.TabIndex                  = 3;
            this.btnExportar.Text                      = "Exportar CSV";
            this.btnExportar.Click                    += new System.EventHandler(this.btnExportar_Click);

            // dgvPagos
            this.dgvPagos.AllowUserToAddRows                      = false;
            this.dgvPagos.Anchor                                  = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Bottom));
            this.dgvPagos.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvPagos.BorderStyle                             = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPagos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.dgvPagos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPagos.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvPagos.EnableHeadersVisualStyles               = false;
            this.dgvPagos.Location                                = new System.Drawing.Point(10, 116);
            this.dgvPagos.Name                                    = "dgvPagos";
            this.dgvPagos.ReadOnly                                = true;
            this.dgvPagos.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size                                    = new System.Drawing.Size(830, 360);
            this.dgvPagos.TabIndex                                = 2;

            // lblTotal
            this.lblTotal.AutoSize  = true;
            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.lblTotal.Location  = new System.Drawing.Point(10, 488);
            this.lblTotal.Name      = "lblTotal";
            this.lblTotal.TabIndex  = 3;

            // lblMeses
            this.lblMeses.AutoSize  = true;
            this.lblMeses.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMeses.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblMeses.Location  = new System.Drawing.Point(280, 488);
            this.lblMeses.Name      = "lblMeses";
            this.lblMeses.TabIndex  = 4;

            // FormConsultaPagos
            this.BackColor     = System.Drawing.Color.FromArgb(248, 250, 255);
            this.ClientSize    = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHeader);
            this.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.Name          = "FormConsultaPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Consultar Pagos";
            this.Load         += new System.EventHandler(this.FormConsultaPagos_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel        pnlHeader, pnlTop;
        private System.Windows.Forms.Label        lblHeader, lblEst, lblTotal, lblMeses;
        private System.Windows.Forms.ComboBox     cmbEstudiante;
        private System.Windows.Forms.Button       btnConsultar, btnExportar;
        private System.Windows.Forms.DataGridView dgvPagos;
    }
}
