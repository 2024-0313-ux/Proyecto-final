using Proyecto_final.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_final.Formularios.Aportes
{
    public partial class FrmHistorialAportes : Form
    {
        public FrmHistorialAportes()
        {
            InitializeComponent();
            Load += FrmHistorialAportes_Load;
        }

        // =========================================
        // LOAD → CARGAR SOCIOS
        // =========================================
        private void FrmHistorialAportes_Load(object sender, EventArgs e)
        {
            CargarSocios();
            lblTotal.Text = "0.00";
        }

        private void CargarSocios()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT IdSocio, Nombre FROM Socios", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboSocio.DataSource = dt;
                cboSocio.DisplayMember = "Nombre";
                cboSocio.ValueMember = "IdSocio";
                cboSocio.SelectedIndex = -1;
            }
        }

        // =========================================
        // BUSCAR HISTORIAL
        // =========================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un socio.");
                return;
            }

            int idSocio = Convert.ToInt32(cboSocio.SelectedValue);

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                // -------- LISTADO --------
                SqlCommand cmd = new SqlCommand(
                    @"SELECT 
                        Fecha,
                        Monto
                      FROM Aportes
                      WHERE IdSocio = @id
                      ORDER BY Fecha DESC", con);

                cmd.Parameters.AddWithValue("@id", idSocio);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHistorial.DataSource = dt;

                // -------- TOTAL --------
                SqlCommand cmdTotal = new SqlCommand(
                    @"SELECT ISNULL(SUM(Monto), 0)
                      FROM Aportes
                      WHERE IdSocio = @id", con);

                cmdTotal.Parameters.AddWithValue("@id", idSocio);

                decimal total = Convert.ToDecimal(cmdTotal.ExecuteScalar());
                lblTotal.Text = total.ToString("N2");
            }
        }
    }
}
