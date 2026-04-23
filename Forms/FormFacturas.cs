using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using accountableSystem.Classes;

namespace accountableSystem.Forms
{
    public partial class FormFacturas : Form
    {
        public FormFacturas() { InitializeComponent(); }

        private void FormFacturas_Load(object sender, EventArgs e) { CargarEstudiantes(); CargarFacturas(); }

        private void CargarEstudiantes()
        {
            try
            {
                using (var con = Conexion.Abrir())
                using (var da = new MySqlDataAdapter(
                    "SELECT IdEstudiante, CONCAT(Nombre,' ',Apellido) AS NombreCompleto FROM Estudiantes WHERE Activo=1 ORDER BY Apellido", con))
                {
                    var dt = new DataTable(); da.Fill(dt);
                    var f = dt.NewRow(); f["IdEstudiante"]=0; f["NombreCompleto"]="-- Todos --"; dt.Rows.InsertAt(f,0);
                    cmbEstudiante.DataSource=dt; cmbEstudiante.DisplayMember="NombreCompleto"; cmbEstudiante.ValueMember="IdEstudiante";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: "+ex.Message); }
        }

        private void CargarFacturas(int idEst = 0)
        {
            try
            {
                using (var con = Conexion.Abrir())
                {
                    string sql = @"SELECT f.IdFactura, f.NumFactura, CONCAT(e.Nombre,' ',e.Apellido) AS Estudiante,
                                          f.FechaEmision, f.Total, f.Estado
                                   FROM   Facturas f
                                   INNER  JOIN Estudiantes e ON e.IdEstudiante=f.IdEstudiante
                                   WHERE  (@id=0 OR f.IdEstudiante=@id)
                                   ORDER  BY f.FechaEmision DESC";
                    using (var da = new MySqlDataAdapter(sql, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@id", idEst);
                        var dt = new DataTable(); da.Fill(dt); dgvFacturas.DataSource = dt;
                    }
                }
                if (dgvFacturas.Columns.Contains("IdFactura")) dgvFacturas.Columns["IdFactura"].Visible=false;
                ActualizarTotal();
            }
            catch (Exception ex) { MessageBox.Show("Error: "+ex.Message); }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                if (row.Cells["Estado"].Value?.ToString()=="Emitida" && row.Cells["Total"].Value!=DBNull.Value)
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            lblTotalFacturado.Text = $"Total Facturado (Emitidas): RD$ {total:N2}";
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            int id = cmbEstudiante.SelectedValue!=null ? Convert.ToInt32(cmbEstudiante.SelectedValue) : 0;
            CargarFacturas(id);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null) return;
            string estado = dgvFacturas.CurrentRow.Cells["Estado"].Value?.ToString();
            if (estado == "Anulada") { MessageBox.Show("Esta factura ya está anulada."); return; }
            if (MessageBox.Show("¿Anular esta factura?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes) return;
            try
            {
                int id = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["IdFactura"].Value);
                using (var con = Conexion.Abrir())
                using (var cmd = new MySqlCommand("UPDATE Facturas SET Estado='Anulada' WHERE IdFactura=@id", con))
                { cmd.Parameters.AddWithValue("@id",id); cmd.ExecuteNonQuery(); }
                btnVerFacturas_Click(null,null);
            }
            catch (Exception ex) { MessageBox.Show("Error: "+ex.Message); }
        }
    }
}
