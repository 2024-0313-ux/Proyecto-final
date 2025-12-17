using System;
using System.Windows.Forms;

namespace Proyecto_final.Formularios.Generales
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

            // Habilitar MDI
            this.IsMdiContainer = true;

            // Centrar el formulario principal
            this.StartPosition = FormStartPosition.CenterScreen;

            // Eventos de los botones
            btnSocios.Click += btnSocios_Click;
            btnAportes.Click += btnAportes_Click;
            btnPrestamos.Click += btnPrestamos_Click;
            btnPagos.Click += btnPagos_Click;
            btnReportes.Click += btnReportes_Click;
            btnUsuarios.Click += BtnUsuarios_Click;
            btnSalir.Click += btnSalir_Click;
        }

        /// Función general para abrir formularios MDI sin duplicarlos
        private Form AbrirFormulario(Type formType)
        {
            // Si ya está abierto, activarlo
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    f.Activate();
                    return f;
                }
            }

            // Si no está abierto, crearlo
            Form nuevo = (Form)Activator.CreateInstance(formType);
            nuevo.MdiParent = this;
            nuevo.StartPosition = FormStartPosition.CenterScreen;
            nuevo.Show();
            return nuevo;
        }

        // ---- BOTONES ----

        private void btnSocios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(Proyecto_final.Formularios.Socios.FrmSocios));
        }

        private void btnAportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(Proyecto_final.Formularios.Aportes.FrmRegistrarAporte));
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(Proyecto_final.Formularios.Prestamos.FrmPrestamos));
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(Proyecto_final.Formularios.Pagos.FrmRegistrarPago));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(Proyecto_final.Formularios.Reportes.FrmReporteGlobal));
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(Proyecto_final.Formularios.Usuarios.FrmUsuarios));
        }

        // --- CERRAR SESIÓN ---
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btmSocios_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btmSocios_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
