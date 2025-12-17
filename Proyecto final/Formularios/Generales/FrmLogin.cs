using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_final.Formularios.Generales
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private bool ValidarLogin(string usuario, string clave)
        {
            using (SqlConnection conn = Clases.DBConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Usuarios WHERE Usuario = @u AND Clave = @c";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", clave);

                SqlDataReader dr = cmd.ExecuteReader();
                return dr.Read(); // True si encontró un usuario
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string u = txtUsuario.Text.Trim();
            string c = txtPassword.Text.Trim();

            if (u == "" || c == "")
            {
                MessageBox.Show("Debe llenar ambos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarLogin(u, c))
            {
                // Login correcto → ir al menú principal
                Formularios.Generales.FrmMenuPrincipal menu = new Formularios.Generales.FrmMenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
