using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_final.Clases;

namespace Proyecto_final.Formularios.Pagos
{
    public partial class FrmRegistrarPago : Form
    {
        public FrmRegistrarPago()
        {
            InitializeComponent();
        }

        // ================================
        // LOAD
        // ================================
        private void FrmRegistrarPago_Load(object sender, EventArgs e)
        {
            CargarSocios();
            dtpPago.Value = DateTime.Now;
        }

        // ================================
        // CARGAR SOCIOS
        // ================================
        private void CargarSocios()
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

        // ================================
        // CARGAR PRÉSTAMOS DEL SOCIO
        // ================================
        private void cmbSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSocio.SelectedIndex == -1) return;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT IdPrestamo 
                    FROM Prestamos 
                    WHERE IdSocio = @id AND Estado = 'Aprobado'",
                    con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@id", cboSocio.SelectedValue);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboPrestamo.DataSource = dt;
                cboPrestamo.DisplayMember = "IdPrestamo";
                cboPrestamo.ValueMember = "IdPrestamo";
                cboPrestamo.SelectedIndex = -1;
            }
        }

        // ================================
        // REGISTRAR PAGO
        // ================================
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cboSocio.SelectedIndex == -1 ||
                cboPrestamo.SelectedIndex == -1 ||
                txtMonto.Text == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            decimal monto = Convert.ToDecimal(txtMonto.Text);
            int idPrestamo = Convert.ToInt32(cboPrestamo.SelectedValue);

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // INSERTAR PAGO
                    SqlCommand cmdPago = new SqlCommand(@"
                        INSERT INTO Pagos (IdPrestamo, Monto, FechaPago)
                        VALUES (@p, @m, @f)",
                        con, tran);

                    cmdPago.Parameters.AddWithValue("@p", idPrestamo);
                    cmdPago.Parameters.AddWithValue("@m", monto);
                    cmdPago.Parameters.AddWithValue("@f", dtpPago.Value);
                    cmdPago.ExecuteNonQuery();

                    // ACTUALIZAR SALDO
                    SqlCommand cmdUpdate = new SqlCommand(@"
                        UPDATE Prestamos
                        SET SaldoPendiente = SaldoPendiente - @m
                        WHERE IdPrestamo = @p",
                        con, tran);

                    cmdUpdate.Parameters.AddWithValue("@m", monto);
                    cmdUpdate.Parameters.AddWithValue("@p", idPrestamo);
                    cmdUpdate.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }

            MessageBox.Show("Pago registrado correctamente.");
            this.Close();
        }

        // ================================
        // CANCELAR
        // ================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
