using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_final.Clases;
using Proyecto_final.Formularios.Socios;

namespace Proyecto_final.Formularios.Socios
{
    public partial class FrmSocios : Form
    {
        public FrmSocios()
        {
            InitializeComponent();
        }

        // ================================
        // CARGAR LISTA DE SOCIOS
        // ================================
        private void CargarSocios(string filtro = "")
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT IdSocio, Nombre, Cedula, Correo, Telefono, Direccion FROM Socios";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    query += " WHERE Nombre LIKE @filtro OR Cedula LIKE @filtro";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                if (!string.IsNullOrWhiteSpace(filtro))
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSocios.DataSource = dt;
            }
        }

        // ================================
        // FORM LOAD
        // ================================
        private void FrmSocios_Load(object sender, EventArgs e)
        {
            CargarSocios();
        }

        // ================================
        // BUSCAR
        // ================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarSocios(txtBuscar.Text.Trim());
        }

        // ================================
        // NUEVO
        // ================================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmSocioDetalle frm = new FrmSocioDetalle();
            frm.ShowDialog();
            CargarSocios();
        }

        // ================================
        // EDITAR
        // ================================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un socio.");
                return;
            }

            int id = Convert.ToInt32(dgvSocios.SelectedRows[0].Cells["IdSocio"].Value);

            FrmSocioDetalle frm = new FrmSocioDetalle();
            frm.IdSocio = id;
            frm.ShowDialog();
            CargarSocios();
        }

        // ================================
        // ELIMINAR
        // ================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un socio.");
                return;
            }

            int id = Convert.ToInt32(dgvSocios.SelectedRows[0].Cells["IdSocio"].Value);

            DialogResult r = MessageBox.Show("¿Seguro que deseas eliminar este socio?",
                                             "Confirmación",
                                             MessageBoxButtons.YesNo);

            if (r == DialogResult.No) return;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Socios WHERE IdSocio=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            CargarSocios();
        }

        private void dgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
