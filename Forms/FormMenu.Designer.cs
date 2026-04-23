namespace accountableSystem.Forms
{
    partial class FormMenu
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
            this.lblBienvenido    = new System.Windows.Forms.Label();
            this.lblTitulo        = new System.Windows.Forms.Label();
            this.pnlGrid          = new System.Windows.Forms.Panel();
            this.btnCerrarSesion  = new System.Windows.Forms.Button();
            this.btnReportes      = new System.Windows.Forms.Button();
            this.btnConsultaPagos = new System.Windows.Forms.Button();
            this.btnConsultaEst   = new System.Windows.Forms.Button();
            this.btnFacturas      = new System.Windows.Forms.Button();
            this.btnPagos         = new System.Windows.Forms.Button();
            this.btnContactos     = new System.Windows.Forms.Button();
            this.btnEstudiantes   = new System.Windows.Forms.Button();
            this.btnUsuarios      = new System.Windows.Forms.Button();
            this.statusStrip1     = new System.Windows.Forms.StatusStrip();
            this.tsLabel          = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlHeader.Controls.Add(this.lblBienvenido);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height   = 80;
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Height    = 44;
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "accountableSystem - Menu Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblBienvenido
            this.lblBienvenido.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.lblBienvenido.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblBienvenido.Height    = 26;
            this.lblBienvenido.Name      = "lblBienvenido";
            this.lblBienvenido.TabIndex  = 1;
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlGrid
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlGrid.Controls.Add(this.btnCerrarSesion);
            this.pnlGrid.Controls.Add(this.btnReportes);
            this.pnlGrid.Controls.Add(this.btnConsultaPagos);
            this.pnlGrid.Controls.Add(this.btnConsultaEst);
            this.pnlGrid.Controls.Add(this.btnFacturas);
            this.pnlGrid.Controls.Add(this.btnPagos);
            this.pnlGrid.Controls.Add(this.btnContactos);
            this.pnlGrid.Controls.Add(this.btnEstudiantes);
            this.pnlGrid.Controls.Add(this.btnUsuarios);
            this.pnlGrid.Location  = new System.Drawing.Point(30, 96);
            this.pnlGrid.Name      = "pnlGrid";
            this.pnlGrid.Size      = new System.Drawing.Size(700, 450);
            this.pnlGrid.TabIndex  = 1;

            // btnUsuarios
            this.btnUsuarios.BackColor                 = System.Drawing.Color.FromArgb(22, 101, 52);
            this.btnUsuarios.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor                 = System.Drawing.Color.White;
            this.btnUsuarios.Location                  = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name                      = "btnUsuarios";
            this.btnUsuarios.Size                      = new System.Drawing.Size(160, 70);
            this.btnUsuarios.TabIndex                  = 0;
            this.btnUsuarios.Text                      = "Usuarios\n(Solo Admin)";
            this.btnUsuarios.Click                    += new System.EventHandler(this.btnUsuarios_Click);

            // btnEstudiantes
            this.btnEstudiantes.BackColor                 = System.Drawing.Color.FromArgb(20, 83, 45);
            this.btnEstudiantes.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiantes.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEstudiantes.ForeColor                 = System.Drawing.Color.White;
            this.btnEstudiantes.Location                  = new System.Drawing.Point(170, 0);
            this.btnEstudiantes.Name                      = "btnEstudiantes";
            this.btnEstudiantes.Size                      = new System.Drawing.Size(160, 70);
            this.btnEstudiantes.TabIndex                  = 1;
            this.btnEstudiantes.Text                      = "Estudiantes";
            this.btnEstudiantes.Click                    += new System.EventHandler(this.btnEstudiantes_Click);

            // btnContactos
            this.btnContactos.BackColor                 = System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnContactos.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnContactos.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactos.FlatAppearance.BorderSize = 0;
            this.btnContactos.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnContactos.ForeColor                 = System.Drawing.Color.White;
            this.btnContactos.Location                  = new System.Drawing.Point(340, 0);
            this.btnContactos.Name                      = "btnContactos";
            this.btnContactos.Size                      = new System.Drawing.Size(160, 70);
            this.btnContactos.TabIndex                  = 2;
            this.btnContactos.Text                      = "Contactos";
            this.btnContactos.Click                    += new System.EventHandler(this.btnContactos_Click);

            // btnPagos
            this.btnPagos.BackColor                 = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnPagos.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPagos.ForeColor                 = System.Drawing.Color.White;
            this.btnPagos.Location                  = new System.Drawing.Point(510, 0);
            this.btnPagos.Name                      = "btnPagos";
            this.btnPagos.Size                      = new System.Drawing.Size(160, 70);
            this.btnPagos.TabIndex                  = 3;
            this.btnPagos.Text                      = "Pagos";
            this.btnPagos.Click                    += new System.EventHandler(this.btnPagos_Click);

            // btnFacturas
            this.btnFacturas.BackColor                 = System.Drawing.Color.FromArgb(194, 65, 12);
            this.btnFacturas.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFacturas.ForeColor                 = System.Drawing.Color.White;
            this.btnFacturas.Location                  = new System.Drawing.Point(0, 80);
            this.btnFacturas.Name                      = "btnFacturas";
            this.btnFacturas.Size                      = new System.Drawing.Size(160, 70);
            this.btnFacturas.TabIndex                  = 4;
            this.btnFacturas.Text                      = "Facturas";
            this.btnFacturas.Click                    += new System.EventHandler(this.btnFacturas_Click);

            // btnConsultaEst
            this.btnConsultaEst.BackColor                 = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnConsultaEst.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaEst.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEst.FlatAppearance.BorderSize = 0;
            this.btnConsultaEst.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConsultaEst.ForeColor                 = System.Drawing.Color.White;
            this.btnConsultaEst.Location                  = new System.Drawing.Point(170, 80);
            this.btnConsultaEst.Name                      = "btnConsultaEst";
            this.btnConsultaEst.Size                      = new System.Drawing.Size(160, 70);
            this.btnConsultaEst.TabIndex                  = 5;
            this.btnConsultaEst.Text                      = "Consultar\nEstudiante";
            this.btnConsultaEst.Click                    += new System.EventHandler(this.btnConsultaEst_Click);

            // btnConsultaPagos
            this.btnConsultaPagos.BackColor                 = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnConsultaPagos.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaPagos.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPagos.FlatAppearance.BorderSize = 0;
            this.btnConsultaPagos.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConsultaPagos.ForeColor                 = System.Drawing.Color.White;
            this.btnConsultaPagos.Location                  = new System.Drawing.Point(340, 80);
            this.btnConsultaPagos.Name                      = "btnConsultaPagos";
            this.btnConsultaPagos.Size                      = new System.Drawing.Size(160, 70);
            this.btnConsultaPagos.TabIndex                  = 6;
            this.btnConsultaPagos.Text                      = "Consultar\nPagos";
            this.btnConsultaPagos.Click                    += new System.EventHandler(this.btnConsultaPagos_Click);

            // btnReportes
            this.btnReportes.BackColor                 = System.Drawing.Color.FromArgb(126, 34, 206);
            this.btnReportes.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.Font                      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor                 = System.Drawing.Color.White;
            this.btnReportes.Location                  = new System.Drawing.Point(510, 80);
            this.btnReportes.Name                      = "btnReportes";
            this.btnReportes.Size                      = new System.Drawing.Size(160, 70);
            this.btnReportes.TabIndex                  = 7;
            this.btnReportes.Text                      = "Reportes /\nDashboard";
            this.btnReportes.Click                    += new System.EventHandler(this.btnReportes_Click);

            // btnCerrarSesion
            this.btnCerrarSesion.BackColor                 = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnCerrarSesion.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.Font                      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor                 = System.Drawing.Color.White;
            this.btnCerrarSesion.Location                  = new System.Drawing.Point(270, 200);
            this.btnCerrarSesion.Name                      = "btnCerrarSesion";
            this.btnCerrarSesion.Size                      = new System.Drawing.Size(160, 36);
            this.btnCerrarSesion.TabIndex                  = 8;
            this.btnCerrarSesion.Text                      = "Cerrar Sesion";
            this.btnCerrarSesion.Click                    += new System.EventHandler(this.btnCerrarSesion_Click);

            // statusStrip1
            this.statusStrip1.BackColor  = System.Drawing.Color.FromArgb(30, 58, 95);
            this.statusStrip1.ForeColor  = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tsLabel });
            this.statusStrip1.Name       = "statusStrip1";
            this.statusStrip1.TabIndex   = 2;

            // tsLabel
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Text = "";

            // FormMenu
            this.BackColor       = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize      = new System.Drawing.Size(760, 600);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip1);
            this.Font            = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormMenu";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "accountableSystem — Menu Principal";
            this.Load           += new System.EventHandler(this.FormMenu_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel       pnlHeader, pnlGrid;
        private System.Windows.Forms.Label       lblTitulo, lblBienvenido;
        private System.Windows.Forms.Button      btnUsuarios, btnEstudiantes, btnContactos, btnPagos;
        private System.Windows.Forms.Button      btnFacturas, btnConsultaEst, btnConsultaPagos, btnReportes, btnCerrarSesion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
    }
}
