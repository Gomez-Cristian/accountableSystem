namespace accountableSystem.Forms
{
    partial class FormConsultaEst
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
            this.pnlSearch      = new System.Windows.Forms.Panel();
            this.lblConteo      = new System.Windows.Forms.Label();
            this.btnLimpiar     = new System.Windows.Forms.Button();
            this.btnBuscar      = new System.Windows.Forms.Button();
            this.txtBuscar      = new System.Windows.Forms.TextBox();
            this.splitV         = new System.Windows.Forms.SplitContainer();
            this.dgvResultados  = new System.Windows.Forms.DataGridView();
            this.pnlDetalle     = new System.Windows.Forms.Panel();
            this.dgvPagos       = new System.Windows.Forms.DataGridView();
            this.lblUltPagos    = new System.Windows.Forms.Label();
            this.lblDetTelefono = new System.Windows.Forms.Label();
            this.lblDetTutor    = new System.Windows.Forms.Label();
            this.lblDetEstado   = new System.Windows.Forms.Label();
            this.lblDetIngreso  = new System.Windows.Forms.Label();
            this.lblDetCurso    = new System.Windows.Forms.Label();
            this.lblDetNombre   = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitV)).BeginInit();
            this.splitV.Panel1.SuspendLayout();
            this.splitV.Panel2.SuspendLayout();
            this.splitV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
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
            this.lblHeader.Text      = "Consultar Estudiante";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlSearch
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblConteo);
            this.pnlSearch.Controls.Add(this.btnLimpiar);
            this.pnlSearch.Controls.Add(this.btnBuscar);
            this.pnlSearch.Controls.Add(this.txtBuscar);
            this.pnlSearch.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height   = 54;
            this.pnlSearch.Name     = "pnlSearch";
            this.pnlSearch.Padding  = new System.Windows.Forms.Padding(10, 12, 10, 0);
            this.pnlSearch.TabIndex = 1;

            // txtBuscar
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location    = new System.Drawing.Point(10, 14);
            this.txtBuscar.Name        = "txtBuscar";
            this.txtBuscar.Size        = new System.Drawing.Size(400, 26);
            this.txtBuscar.TabIndex    = 0;
            this.txtBuscar.KeyDown    += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);

            // btnBuscar
            this.btnBuscar.BackColor                 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnBuscar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor                 = System.Drawing.Color.White;
            this.btnBuscar.Location                  = new System.Drawing.Point(420, 13);
            this.btnBuscar.Name                      = "btnBuscar";
            this.btnBuscar.Size                      = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex                  = 1;
            this.btnBuscar.Text                      = "Buscar";
            this.btnBuscar.Click                    += new System.EventHandler(this.btnBuscar_Click);

            // btnLimpiar
            this.btnLimpiar.BackColor                 = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnLimpiar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor                 = System.Drawing.Color.White;
            this.btnLimpiar.Location                  = new System.Drawing.Point(530, 13);
            this.btnLimpiar.Name                      = "btnLimpiar";
            this.btnLimpiar.Size                      = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex                  = 2;
            this.btnLimpiar.Text                      = "Limpiar";
            this.btnLimpiar.Click                    += new System.EventHandler(this.btnLimpiar_Click);

            // lblConteo
            this.lblConteo.AutoSize  = true;
            this.lblConteo.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblConteo.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblConteo.Location  = new System.Drawing.Point(648, 16);
            this.lblConteo.Name      = "lblConteo";
            this.lblConteo.TabIndex  = 3;

            // splitV
            this.splitV.Dock             = System.Windows.Forms.DockStyle.Fill;
            this.splitV.Name             = "splitV";
            this.splitV.Orientation      = System.Windows.Forms.Orientation.Horizontal;
            this.splitV.Panel1.Controls.Add(this.dgvResultados);
            this.splitV.Panel1.Padding   = new System.Windows.Forms.Padding(8);
            this.splitV.Panel2.Controls.Add(this.pnlDetalle);
            this.splitV.Panel2.Padding   = new System.Windows.Forms.Padding(8);
            this.splitV.SplitterDistance = 250;
            this.splitV.TabIndex         = 2;

            // dgvResultados
            this.dgvResultados.AllowUserToAddRows                      = false;
            this.dgvResultados.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle                             = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvResultados.Dock                                    = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.EnableHeadersVisualStyles               = false;
            this.dgvResultados.Name                                    = "dgvResultados";
            this.dgvResultados.ReadOnly                                = true;
            this.dgvResultados.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.TabIndex                                = 0;
            this.dgvResultados.SelectionChanged                       += new System.EventHandler(this.dgvResultados_SelectionChanged);

            // pnlDetalle
            this.pnlDetalle.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            this.pnlDetalle.Controls.Add(this.dgvPagos);
            this.pnlDetalle.Controls.Add(this.lblUltPagos);
            this.pnlDetalle.Controls.Add(this.lblDetTelefono);
            this.pnlDetalle.Controls.Add(this.lblDetTutor);
            this.pnlDetalle.Controls.Add(this.lblDetEstado);
            this.pnlDetalle.Controls.Add(this.lblDetIngreso);
            this.pnlDetalle.Controls.Add(this.lblDetCurso);
            this.pnlDetalle.Controls.Add(this.lblDetNombre);
            this.pnlDetalle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalle.Name      = "pnlDetalle";
            this.pnlDetalle.TabIndex  = 0;

            // lblDetNombre
            this.lblDetNombre.AutoSize  = true;
            this.lblDetNombre.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetNombre.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDetNombre.Location  = new System.Drawing.Point(10, 8);
            this.lblDetNombre.Name      = "lblDetNombre";
            this.lblDetNombre.TabIndex  = 0;

            // lblDetCurso
            this.lblDetCurso.AutoSize  = true;
            this.lblDetCurso.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetCurso.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDetCurso.Location  = new System.Drawing.Point(10, 30);
            this.lblDetCurso.Name      = "lblDetCurso";
            this.lblDetCurso.TabIndex  = 1;

            // lblDetIngreso
            this.lblDetIngreso.AutoSize  = true;
            this.lblDetIngreso.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetIngreso.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDetIngreso.Location  = new System.Drawing.Point(10, 52);
            this.lblDetIngreso.Name      = "lblDetIngreso";
            this.lblDetIngreso.TabIndex  = 2;

            // lblDetEstado
            this.lblDetEstado.AutoSize  = true;
            this.lblDetEstado.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetEstado.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDetEstado.Location  = new System.Drawing.Point(280, 8);
            this.lblDetEstado.Name      = "lblDetEstado";
            this.lblDetEstado.TabIndex  = 3;

            // lblDetTutor
            this.lblDetTutor.AutoSize  = true;
            this.lblDetTutor.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetTutor.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDetTutor.Location  = new System.Drawing.Point(280, 30);
            this.lblDetTutor.Name      = "lblDetTutor";
            this.lblDetTutor.TabIndex  = 4;

            // lblDetTelefono
            this.lblDetTelefono.AutoSize  = true;
            this.lblDetTelefono.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetTelefono.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDetTelefono.Location  = new System.Drawing.Point(280, 52);
            this.lblDetTelefono.Name      = "lblDetTelefono";
            this.lblDetTelefono.TabIndex  = 5;

            // lblUltPagos
            this.lblUltPagos.AutoSize  = true;
            this.lblUltPagos.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUltPagos.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblUltPagos.Location  = new System.Drawing.Point(10, 76);
            this.lblUltPagos.Name      = "lblUltPagos";
            this.lblUltPagos.TabIndex  = 6;
            this.lblUltPagos.Text      = "Ultimos pagos:";

            // dgvPagos
            this.dgvPagos.AllowUserToAddRows                      = false;
            this.dgvPagos.Anchor                                  = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvPagos.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvPagos.BorderStyle                             = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPagos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 148, 136);
            this.dgvPagos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPagos.EnableHeadersVisualStyles               = false;
            this.dgvPagos.Location                                = new System.Drawing.Point(10, 96);
            this.dgvPagos.Name                                    = "dgvPagos";
            this.dgvPagos.ReadOnly                                = true;
            this.dgvPagos.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size                                    = new System.Drawing.Size(940, 120);
            this.dgvPagos.TabIndex                                = 7;

            // FormConsultaEst
            this.BackColor     = System.Drawing.Color.FromArgb(248, 250, 255);
            this.ClientSize    = new System.Drawing.Size(980, 620);
            this.Controls.Add(this.splitV);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.Name          = "FormConsultaEst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Consultar Estudiante";
            this.Load         += new System.EventHandler(this.FormConsultaEst_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.splitV.Panel1.ResumeLayout(false);
            this.splitV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitV)).EndInit();
            this.splitV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel           pnlHeader, pnlSearch, pnlDetalle;
        private System.Windows.Forms.Label           lblHeader, lblConteo;
        private System.Windows.Forms.Label           lblDetNombre, lblDetCurso, lblDetIngreso, lblDetEstado, lblDetTutor, lblDetTelefono, lblUltPagos;
        private System.Windows.Forms.TextBox         txtBuscar;
        private System.Windows.Forms.Button          btnBuscar, btnLimpiar;
        private System.Windows.Forms.SplitContainer  splitV;
        private System.Windows.Forms.DataGridView    dgvResultados, dgvPagos;
    }
}
