namespace accountableSystem.Forms
{
    partial class FormReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend    legend1    = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title     title1     = new System.Windows.Forms.DataVisualization.Charting.Title();

            this.pnlHeader    = new System.Windows.Forms.Panel();
            this.lblHeader    = new System.Windows.Forms.Label();
            this.tabControl   = new System.Windows.Forms.TabControl();
            this.tabDash      = new System.Windows.Forms.TabPage();
            this.chartPagos   = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlKpis      = new System.Windows.Forms.Panel();
            this.pnlK4        = new System.Windows.Forms.Panel();
            this.lblKpiMesActual     = new System.Windows.Forms.Label();
            this.lblK4Title   = new System.Windows.Forms.Label();
            this.pnlK3        = new System.Windows.Forms.Panel();
            this.lblKpiFacturas      = new System.Windows.Forms.Label();
            this.lblK3Title   = new System.Windows.Forms.Label();
            this.pnlK2        = new System.Windows.Forms.Panel();
            this.lblKpiEstudiantes   = new System.Windows.Forms.Label();
            this.lblK2Title   = new System.Windows.Forms.Label();
            this.pnlK1        = new System.Windows.Forms.Panel();
            this.lblKpiTotal  = new System.Windows.Forms.Label();
            this.lblK1Title   = new System.Windows.Forms.Label();
            this.tabRep       = new System.Windows.Forms.TabPage();
            this.lblTotalMes  = new System.Windows.Forms.Label();
            this.dgvReporte   = new System.Windows.Forms.DataGridView();
            this.pnlRepTop    = new System.Windows.Forms.Panel();
            this.btnExportar  = new System.Windows.Forms.Button();
            this.btnGenerar   = new System.Windows.Forms.Button();
            this.cmbMes       = new System.Windows.Forms.ComboBox();
            this.lblMesFiltro = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPagos)).BeginInit();
            this.pnlKpis.SuspendLayout();
            this.pnlK4.SuspendLayout();
            this.pnlK3.SuspendLayout();
            this.pnlK2.SuspendLayout();
            this.pnlK1.SuspendLayout();
            this.tabRep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.pnlRepTop.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(126, 34, 206);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height   = 56;
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.TabIndex = 0;

            // lblHeader
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Reportes y Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // tabControl
            this.tabControl.Controls.Add(this.tabDash);
            this.tabControl.Controls.Add(this.tabRep);
            this.tabControl.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabControl.Name     = "tabControl";
            this.tabControl.TabIndex = 1;

            // tabDash
            this.tabDash.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.tabDash.Controls.Add(this.chartPagos);
            this.tabDash.Controls.Add(this.pnlKpis);
            this.tabDash.Name     = "tabDash";
            this.tabDash.Padding  = new System.Windows.Forms.Padding(10);
            this.tabDash.TabIndex = 0;
            this.tabDash.Text     = " Dashboard ";

            // pnlKpis
            this.pnlKpis.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlKpis.Controls.Add(this.pnlK4);
            this.pnlKpis.Controls.Add(this.pnlK3);
            this.pnlKpis.Controls.Add(this.pnlK2);
            this.pnlKpis.Controls.Add(this.pnlK1);
            this.pnlKpis.Location = new System.Drawing.Point(10, 10);
            this.pnlKpis.Name     = "pnlKpis";
            this.pnlKpis.Size     = new System.Drawing.Size(960, 120);
            this.pnlKpis.TabIndex = 0;

            // pnlK1
            this.pnlK1.BackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.pnlK1.Controls.Add(this.lblKpiTotal);
            this.pnlK1.Controls.Add(this.lblK1Title);
            this.pnlK1.Location  = new System.Drawing.Point(0, 0);
            this.pnlK1.Name      = "pnlK1";
            this.pnlK1.Size      = new System.Drawing.Size(226, 110);
            this.pnlK1.TabIndex  = 0;

            // lblK1Title
            this.lblK1Title.AutoSize  = true;
            this.lblK1Title.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblK1Title.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblK1Title.Location  = new System.Drawing.Point(14, 14);
            this.lblK1Title.Name      = "lblK1Title";
            this.lblK1Title.TabIndex  = 0;
            this.lblK1Title.Text      = "Total Recaudado";

            // lblKpiTotal
            this.lblKpiTotal.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotal.ForeColor = System.Drawing.Color.White;
            this.lblKpiTotal.Location  = new System.Drawing.Point(14, 36);
            this.lblKpiTotal.Name      = "lblKpiTotal";
            this.lblKpiTotal.Size      = new System.Drawing.Size(200, 40);
            this.lblKpiTotal.TabIndex  = 1;
            this.lblKpiTotal.Text      = "—";

            // pnlK2
            this.pnlK2.BackColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.pnlK2.Controls.Add(this.lblKpiEstudiantes);
            this.pnlK2.Controls.Add(this.lblK2Title);
            this.pnlK2.Location  = new System.Drawing.Point(244, 0);
            this.pnlK2.Name      = "pnlK2";
            this.pnlK2.Size      = new System.Drawing.Size(226, 110);
            this.pnlK2.TabIndex  = 1;

            // lblK2Title
            this.lblK2Title.AutoSize  = true;
            this.lblK2Title.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblK2Title.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblK2Title.Location  = new System.Drawing.Point(14, 14);
            this.lblK2Title.Name      = "lblK2Title";
            this.lblK2Title.TabIndex  = 0;
            this.lblK2Title.Text      = "Estudiantes Activos";

            // lblKpiEstudiantes
            this.lblKpiEstudiantes.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiEstudiantes.ForeColor = System.Drawing.Color.White;
            this.lblKpiEstudiantes.Location  = new System.Drawing.Point(14, 36);
            this.lblKpiEstudiantes.Name      = "lblKpiEstudiantes";
            this.lblKpiEstudiantes.Size      = new System.Drawing.Size(200, 40);
            this.lblKpiEstudiantes.TabIndex  = 1;
            this.lblKpiEstudiantes.Text      = "—";

            // pnlK3
            this.pnlK3.BackColor = System.Drawing.Color.FromArgb(194, 65, 12);
            this.pnlK3.Controls.Add(this.lblKpiFacturas);
            this.pnlK3.Controls.Add(this.lblK3Title);
            this.pnlK3.Location  = new System.Drawing.Point(488, 0);
            this.pnlK3.Name      = "pnlK3";
            this.pnlK3.Size      = new System.Drawing.Size(226, 110);
            this.pnlK3.TabIndex  = 2;

            // lblK3Title
            this.lblK3Title.AutoSize  = true;
            this.lblK3Title.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblK3Title.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblK3Title.Location  = new System.Drawing.Point(14, 14);
            this.lblK3Title.Name      = "lblK3Title";
            this.lblK3Title.TabIndex  = 0;
            this.lblK3Title.Text      = "Facturas Emitidas";

            // lblKpiFacturas
            this.lblKpiFacturas.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiFacturas.ForeColor = System.Drawing.Color.White;
            this.lblKpiFacturas.Location  = new System.Drawing.Point(14, 36);
            this.lblKpiFacturas.Name      = "lblKpiFacturas";
            this.lblKpiFacturas.Size      = new System.Drawing.Size(200, 40);
            this.lblKpiFacturas.TabIndex  = 1;
            this.lblKpiFacturas.Text      = "—";

            // pnlK4
            this.pnlK4.BackColor = System.Drawing.Color.FromArgb(126, 34, 206);
            this.pnlK4.Controls.Add(this.lblKpiMesActual);
            this.pnlK4.Controls.Add(this.lblK4Title);
            this.pnlK4.Location  = new System.Drawing.Point(732, 0);
            this.pnlK4.Name      = "pnlK4";
            this.pnlK4.Size      = new System.Drawing.Size(226, 110);
            this.pnlK4.TabIndex  = 3;

            // lblK4Title
            this.lblK4Title.AutoSize  = true;
            this.lblK4Title.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblK4Title.ForeColor = System.Drawing.Color.FromArgb(200, 230, 255);
            this.lblK4Title.Location  = new System.Drawing.Point(14, 14);
            this.lblK4Title.Name      = "lblK4Title";
            this.lblK4Title.TabIndex  = 0;
            this.lblK4Title.Text      = "Recaudado Mes Actual";

            // lblKpiMesActual
            this.lblKpiMesActual.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiMesActual.ForeColor = System.Drawing.Color.White;
            this.lblKpiMesActual.Location  = new System.Drawing.Point(14, 36);
            this.lblKpiMesActual.Name      = "lblKpiMesActual";
            this.lblKpiMesActual.Size      = new System.Drawing.Size(200, 40);
            this.lblKpiMesActual.TabIndex  = 1;
            this.lblKpiMesActual.Text      = "—";

            // chartPagos
            chartArea1.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            chartArea1.Name      = "Main";
            this.chartPagos.ChartAreas.Add(chartArea1);
            legend1.BackColor    = System.Drawing.Color.Transparent;
            legend1.Font         = new System.Drawing.Font("Segoe UI", 8F);
            legend1.ForeColor    = System.Drawing.Color.White;
            legend1.Name         = "L";
            this.chartPagos.Legends.Add(legend1);
            this.chartPagos.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.chartPagos.Location  = new System.Drawing.Point(10, 138);
            this.chartPagos.Name      = "chartPagos";
            this.chartPagos.Size      = new System.Drawing.Size(960, 450);
            this.chartPagos.TabIndex  = 1;
            title1.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name      = "Title1";
            title1.Text      = "Pagos por Mes (RD$)";
            this.chartPagos.Titles.Add(title1);

            // tabRep
            this.tabRep.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            this.tabRep.Controls.Add(this.dgvReporte);
            this.tabRep.Controls.Add(this.pnlRepTop);
            this.tabRep.Controls.Add(this.lblTotalMes);
            this.tabRep.Name     = "tabRep";
            this.tabRep.TabIndex = 1;
            this.tabRep.Text     = "  Reporte de Pagos  ";

            // pnlRepTop
            this.pnlRepTop.BackColor = System.Drawing.Color.White;
            this.pnlRepTop.Controls.Add(this.btnExportar);
            this.pnlRepTop.Controls.Add(this.btnGenerar);
            this.pnlRepTop.Controls.Add(this.cmbMes);
            this.pnlRepTop.Controls.Add(this.lblMesFiltro);
            this.pnlRepTop.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlRepTop.Height   = 56;
            this.pnlRepTop.Name     = "pnlRepTop";
            this.pnlRepTop.TabIndex = 0;

            // lblMesFiltro
            this.lblMesFiltro.AutoSize  = true;
            this.lblMesFiltro.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMesFiltro.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblMesFiltro.Location  = new System.Drawing.Point(10, 18);
            this.lblMesFiltro.Name      = "lblMesFiltro";
            this.lblMesFiltro.TabIndex  = 0;
            this.lblMesFiltro.Text      = "Filtrar por Mes:";

            // cmbMes
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Location      = new System.Drawing.Point(140, 14);
            this.cmbMes.Name          = "cmbMes";
            this.cmbMes.Size          = new System.Drawing.Size(200, 26);
            this.cmbMes.TabIndex      = 1;

            // btnGenerar
            this.btnGenerar.BackColor                 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGenerar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor                 = System.Drawing.Color.White;
            this.btnGenerar.Location                  = new System.Drawing.Point(354, 13);
            this.btnGenerar.Name                      = "btnGenerar";
            this.btnGenerar.Size                      = new System.Drawing.Size(130, 28);
            this.btnGenerar.TabIndex                  = 2;
            this.btnGenerar.Text                      = "Generar Reporte";
            this.btnGenerar.Click                    += new System.EventHandler(this.btnGenerar_Click);

            // btnExportar
            this.btnExportar.BackColor                 = System.Drawing.Color.FromArgb(22, 101, 52);
            this.btnExportar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.Font                      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor                 = System.Drawing.Color.White;
            this.btnExportar.Location                  = new System.Drawing.Point(494, 13);
            this.btnExportar.Name                      = "btnExportar";
            this.btnExportar.Size                      = new System.Drawing.Size(130, 28);
            this.btnExportar.TabIndex                  = 3;
            this.btnExportar.Text                      = "Exportar CSV";
            this.btnExportar.Click                    += new System.EventHandler(this.btnExportar_Click);

            // dgvReporte
            this.dgvReporte.AllowUserToAddRows                      = false;
            this.dgvReporte.AutoSizeColumnsMode                     = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor                         = System.Drawing.Color.White;
            this.dgvReporte.BorderStyle                             = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(126, 34, 206);
            this.dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporte.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvReporte.Dock                                    = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte.EnableHeadersVisualStyles               = false;
            this.dgvReporte.Name                                    = "dgvReporte";
            this.dgvReporte.ReadOnly                                = true;
            this.dgvReporte.SelectionMode                           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.TabIndex                                = 1;

            // lblTotalMes
            this.lblTotalMes.BackColor  = System.Drawing.Color.White;
            this.lblTotalMes.Dock       = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalMes.Font       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalMes.ForeColor  = System.Drawing.Color.FromArgb(22, 101, 52);
            this.lblTotalMes.Height     = 30;
            this.lblTotalMes.Name       = "lblTotalMes";
            this.lblTotalMes.Padding    = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTotalMes.TabIndex   = 2;
            this.lblTotalMes.TextAlign  = System.Drawing.ContentAlignment.MiddleLeft;

            // FormReportes
            this.BackColor     = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize    = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlHeader);
            this.Font          = new System.Drawing.Font("Segoe UI", 9F);
            this.Name          = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Reportes y Dashboard";
            this.Load         += new System.EventHandler(this.FormReportes_Load);

            this.pnlHeader.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabDash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPagos)).EndInit();
            this.pnlKpis.ResumeLayout(false);
            this.pnlK1.ResumeLayout(false);
            this.pnlK1.PerformLayout();
            this.pnlK2.ResumeLayout(false);
            this.pnlK2.PerformLayout();
            this.pnlK3.ResumeLayout(false);
            this.pnlK3.PerformLayout();
            this.pnlK4.ResumeLayout(false);
            this.pnlK4.PerformLayout();
            this.tabRep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.pnlRepTop.ResumeLayout(false);
            this.pnlRepTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblHeader;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage  tabDash, tabRep;
        private System.Windows.Forms.Panel    pnlKpis;
        private System.Windows.Forms.Panel    pnlK1, pnlK2, pnlK3, pnlK4;
        private System.Windows.Forms.Label    lblK1Title, lblK2Title, lblK3Title, lblK4Title;
        private System.Windows.Forms.Label    lblKpiTotal, lblKpiEstudiantes, lblKpiFacturas, lblKpiMesActual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPagos;
        private System.Windows.Forms.Panel    pnlRepTop;
        private System.Windows.Forms.Label    lblMesFiltro, lblTotalMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button   btnGenerar, btnExportar;
        private System.Windows.Forms.DataGridView dgvReporte;
    }
}
