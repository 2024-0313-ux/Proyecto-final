using Proyecto_final.Formularios.Socios;
using Proyecto_final.Formularios.Prestamos;
using Proyecto_final.Formularios.Aportes;
using Proyecto_final.Formularios.Pagos;
using Proyecto_final.Formularios.Usuarios;
using Proyecto_final.Formularios.Reportes;

namespace Proyecto_final.Formularios.Generales
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private Form AbrirFormulario(Type formType)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == formType)
                {
                    form.Activate();
                    return form;
                }
            }

            Form nuevo = (Form)Activator.CreateInstance(formType);
            nuevo.MdiParent = this;
            nuevo.StartPosition = FormStartPosition.CenterScreen;
            nuevo.Show();
            return nuevo;
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmSocios));
        }

        private void aportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmRegistrarAporte));
        }

        private void historialAportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmHistorialAportes));
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmPrestamos));
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmRegistrarPago));
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmUsuarios));
        }

        private void reporteSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmReporteSocio));
        }

        private void reporteGlobalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(typeof(FrmReporteGlobal));
        }
    }
}
