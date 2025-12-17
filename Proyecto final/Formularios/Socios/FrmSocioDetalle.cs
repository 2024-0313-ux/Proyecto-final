using Proyecto_final.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_final.Formularios.Socios
{
    public partial class FrmSocioDetalle : Form
    {
        private bool esEdicion = false;
        private int idSocio = 0;

        // ================================
        // CONSTRUCTOR NUEVO
        // ================================
        public FrmSocioDetalle()
        {
            InitializeComponent();
        }

        // ================================
        // CONSTRUCTOR EDICIÓN
        // ================================
        public FrmSocioDetalle(int id, string nombre, string cedula,
                               string correo, string telefono, string direccion)
        {
            InitializeComponent();

            esEdicion = true;
            idSocio = id;

            txtNombre.Text = nombre;
            txtCedula.Text = cedula;
            txtCorreo.Text = correo;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion;
        }

        // ================================
        // GUARDAR
        // ================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCedula.Text == "")
            {
                MessageBox.Show("Nombre y cédula son obligatorios.");
                return;
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                if (!esEdicion)
                {
                    cmd.CommandText = @"INSERT INTO Socios
                        (Nombre, Cedula, Correo, Telefono, Direccion)
                        VALUES (@n, @c, @co, @t, @d)";
                }
                else
                {
                    cmd.CommandText = @"UPDATE Socios SET
                        Nombre=@n,
                        Cedula=@c,
                        Correo=@co,
                        Telefono=@t,
                        Direccion=@d
                        WHERE IdSocio=@id";

                    cmd.Parameters.AddWithValue("@id", idSocio);
                }

                cmd.Parameters.AddWithValue("@n", txtNombre.Text);
                cmd.Parameters.AddWithValue("@c", txtCedula.Text);
                cmd.Parameters.AddWithValue("@co", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@t", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@d", txtDireccion.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(esEdicion ? "Socio actualizado." : "Socio registrado.");
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
