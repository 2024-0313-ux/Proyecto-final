using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_final.Clases;
using Proyecto_final.Formularios.Prestamos;

namespace Proyecto_final.Formularios.Prestamos
{
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        // =========================================
        // CARGAR PRÉSTAMOS
        // =========================================
        private void CargarPrestamos(string filtro = "")
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"
                    SELECT 
                        p.IdPrestamo,
                        s.Nombre AS Socio,
                        p.Monto,
                        p.Plazo,
                        p.TasaInteres,
                        p.Estado,
                        p.FechaSolicitud
                    FROM Prestamos p
                    INNER JOIN Socios s ON s.IdSocio = p.IdSocio
                ";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    query += @" WHERE s.Nombre LIKE @filtro 
                                OR p.Estado LIKE @filtro";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                if (!string.IsNullOrWhiteSpace(filtro))
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPrestamos.DataSource = dt;
            }
        }

        // =========================================
        // LOAD
        // =========================================
        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        // =========================================
        // BUSCAR
        // =========================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPrestamos(txtBuscar.Text.Trim());
        }

        // =========================================
        // NUEVO PRÉSTAMO
        // =========================================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmSolicitudPrestamo frm = new FrmSolicitudPrestamo();
            frm.ShowDialog();
            CargarPrestamos();
        }

        // =========================================
        // APROBAR PRÉSTAMO
        // =========================================
        private void btnAprobar_Click(object sender, EventArgs e)
        {
            CambiarEstado("Aprobado");
        }

        // =========================================
        // RECHAZAR PRÉSTAMO
        // =========================================
        private void btnRechazar_Click(object sender, EventArgs e)
        {
            CambiarEstado("Rechazado");
        }

        // =========================================
        // CAMBIAR ESTADO
        // =========================================
        private void CambiarEstado(string nuevoEstado)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un préstamo.");
                return;
            }

            DataGridViewRow row = dgvPrestamos.SelectedRows[0];

            string estadoActual = row.Cells["Estado"].Value.ToString();

            if (estadoActual != "Pendiente")
            {
                MessageBox.Show("Solo se pueden modificar préstamos pendientes.");
                return;
            }

            int idPrestamo = Convert.ToInt32(row.Cells["IdPrestamo"].Value);

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Prestamos SET Estado=@e WHERE IdPrestamo=@id", con);

                cmd.Parameters.AddWithValue("@e", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idPrestamo);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show($"Préstamo {nuevoEstado.ToLower()} correctamente.");
            CargarPrestamos();
        }

        // =========================================
        // VER DETALLE
        // =========================================
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un préstamo.");
                return;
            }

            int idPrestamo = Convert.ToInt32(
                dgvPrestamos.SelectedRows[0].Cells["IdPrestamo"].Value);

            FrmPrestamoDetalle frm = new FrmPrestamoDetalle(idPrestamo);
            frm.ShowDialog();
        }
    }
}
