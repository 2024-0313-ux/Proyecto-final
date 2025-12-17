using Proyecto_final.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_final.Formularios.Prestamos
{
    public partial class FrmSolicitudPrestamo : Form
    {
        public FrmSolicitudPrestamo()
        {
            InitializeComponent();
            Load += FrmSolicitudPrestamo_Load;
        }

        // ============================
        // LOAD → CARGAR SOCIOS
        // ============================
        private void FrmSolicitudPrestamo_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdSocio, Nombre FROM Socios", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboSocio.DataSource = dt;
                cboSocio.DisplayMember = "Nombre";
                cboSocio.ValueMember = "IdSocio";
                cboSocio.SelectedIndex = -1;
            }
        }

        // ============================
        // GUARDAR SOLICITUD
        // ============================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboSocio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un socio.");
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Monto inválido.");
                return;
            }

            if (!decimal.TryParse(txtTasa.Text, out decimal tasa))
            {
                MessageBox.Show("Tasa inválida.");
                return;
            }

            if (!int.TryParse(txtPlazo.Text, out int plazo))
            {
                MessageBox.Show("Plazo inválido.");
                return;
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
        INSERT INTO Prestamos
        (IdSocio, Monto, TasaInteres, Plazo, Estado, FechaSolicitud)
        VALUES (@s, @m, @t, @p, 'Pendiente', GETDATE())", con);

                cmd.Parameters.AddWithValue("@s", cboSocio.SelectedValue);
                cmd.Parameters.AddWithValue("@m", monto);
                cmd.Parameters.AddWithValue("@t", tasa);
                cmd.Parameters.AddWithValue("@p", plazo);

                cmd.ExecuteNonQuery();
            }


            MessageBox.Show("Solicitud registrada correctamente.");
            this.Close();
        }

        // ============================
        // CANCELAR
        // ============================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
