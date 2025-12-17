using Proyecto_final.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_final.Formularios.Aportes
{
    public partial class FrmRegistrarAporte : Form
    {
        public FrmRegistrarAporte()
        {
            InitializeComponent();
            Load += FrmRegistrarAporte_Load;
        }

        // =========================================
        // LOAD → CARGAR SOCIOS
        // =========================================
        private void FrmRegistrarAporte_Load(object sender, EventArgs e)
        {
            CargarSocios();
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
        // GUARDAR APORTE
        // =========================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un socio.");
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Monto inválido.");
                return;
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Aportes (IdSocio, Monto)
                      VALUES (@socio, @monto)", con);

                cmd.Parameters.AddWithValue("@socio", cboSocio.SelectedValue);
                cmd.Parameters.AddWithValue("@monto", monto);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Aporte registrado correctamente.");
            this.Close();
        }

        // =========================================
        // CANCELAR
        // =========================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
