using Proyecto_final.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_final.Formularios.Socios
{
    public partial class FrmSocioDetalle : Form
    {
        public bool EsEdicion = false;
        public int IdSocio = 0;

        public FrmSocioDetalle()
        {
            InitializeComponent();
        }

        // ==========================================================
        // MODO EDICIÓN — CARGA LOS DATOS DEL SOCIO
        // ==========================================================
        public void ModoEdicion(int id, string nombre, string cedula,
                                string correo, string telefono, string direccion)
        {
            EsEdicion = true;
            IdSocio = id;

            txtId.Text = id.ToString();
            txtNombre.Text = nombre;
            txtCedula.Text = cedula;
            txtCorreo.Text = correo;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion; // <-- SIN TILDE
        }

        // ==========================================================
        // BOTÓN GUARDAR
        // ==========================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCedula.Text == "")
            {
                MessageBox.Show("El nombre y la cédula son obligatorios.");
                return;
            }

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (!EsEdicion)
                {
                    // Crear socio
                    cmd.CommandText = @"INSERT INTO Socios 
                        (Nombre, Cedula, Correo, Telefono, Direccion)
                        VALUES (@n, @c, @co, @t, @d)";
                }
                else
                {
                    // Editar socio
                    cmd.CommandText = @"UPDATE Socios SET
                        Nombre = @n,
                        Cedula = @c,
                        Correo = @co,
                        Telefono = @t,
                        Direccion = @d
                        WHERE IdSocio = @id";

                    cmd.Parameters.AddWithValue("@id", IdSocio);
                }

                cmd.Parameters.AddWithValue("@n", txtNombre.Text);
                cmd.Parameters.AddWithValue("@c", txtCedula.Text);
                cmd.Parameters.AddWithValue("@co", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@t", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@d", txtDireccion.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(EsEdicion ? "Socio actualizado." : "Socio registrado.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ==========================================================
        // BOTÓN CANCELAR
        // ==========================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
