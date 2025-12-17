using Proyecto_final.Clases;
using Proyecto_final.Formularios.Pagos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_final.Formularios.Prestamos
{
    public partial class FrmPrestamoDetalle : Form
    {
        private int idPrestamo;
        private decimal montoPrestamo = 0;

        // ================================
        // CONSTRUCTOR
        // ================================
        public FrmPrestamoDetalle(int id)
        {
            InitializeComponent();
            idPrestamo = id;
        }

        // ================================
        // LOAD
        // ================================
        private void FrmPrestamoDetalle_Load(object sender, EventArgs e)
        {
            CargarPrestamo();
            CargarPagos();
            CalcularSaldo();
        }

        // ================================
        // CARGAR PRESTAMO
        // ================================
        private void CargarPrestamo()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT 
                        p.IdPrestamo,
                        s.Nombre,
                        p.Monto,
                        p.TasaInteres,
                        p.Plazo
                    FROM Prestamos p
                    INNER JOIN Socios s ON s.IdSocio = p.IdSocio
                    WHERE p.IdPrestamo = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idPrestamo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblIdPrestamo.Text = dr["IdPrestamo"].ToString();
                    lblSocio.Text = dr["Nombre"].ToString();

                    montoPrestamo = Convert.ToDecimal(dr["Monto"]);

                    lblMonto.Text = montoPrestamo.ToString("N2");
                    lblTasa.Text = dr["TasaInteres"].ToString() + " %";
                    lblPlazos.Text = dr["Plazo"].ToString() + " meses";
                }
            }
        }

        // ================================
        // CARGAR PAGOS
        // ================================
        private void CargarPagos()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT 
                        IdPago,
                        Monto,
                        FechaPago
                    FROM Pagos
                    WHERE IdPrestamo = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idPrestamo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPagos.DataSource = dt;
            }
        }

        // ================================
        // CALCULAR SALDO
        // ================================
        private void CalcularSaldo()
        {
            decimal totalPagado = 0;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(Monto),0) FROM Pagos WHERE IdPrestamo=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", idPrestamo);

                totalPagado = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            decimal saldoPendiente = montoPrestamo - totalPagado;

            lblTotal.Text = montoPrestamo.ToString("N2");
            lblSaldoPendiente.Text = saldoPendiente.ToString("N2");
        }

        // ================================
        // REGISTRAR PAGO
        // ================================
        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            FrmRegistrarPago frm = new FrmRegistrarPago();
            frm.ShowDialog();

            CargarPagos();
            CalcularSaldo();
        }
    }
}
