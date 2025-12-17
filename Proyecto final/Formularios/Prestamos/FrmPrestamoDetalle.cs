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

namespace Proyecto_final.Formularios.Prestamos
{
    public partial class FrmPrestamoDetalle : Form
    {
        // Cambia la declaración del campo para permitir valores nulos (agrega '?')
        private Panel? panelContenedor;

        public FrmPrestamoDetalle()
        {
            InitializeComponent();
            panelContenedor = new Panel(); // Inicializa el panel para evitar CS8618
        }

        private void FrmPrestamoDetalle_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            // Configuración de calidad
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (panelContenedor == null)
                return;

            // Definir el rectángulo y el radio de la curva
            Rectangle rect = panelContenedor.ClientRectangle;
            int radio = 30; // Curvatura de las esquinas
            rect.Width--; rect.Height--; // Ajuste fino para que no se corte

            // Crear el camino (la forma redonda)
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            path.AddArc(rect.X + rect.Width - radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.X + rect.Width - radio, rect.Y + rect.Height - radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();

            // Aplicar la forma al panel
            panelContenedor.Region = new Region(path);

            // DIBUJAR EL BORDE BLANCO FINO (Clave del diseño)
            using (Pen pen = new Pen(Color.FromArgb(100, 255, 255, 255), 1)) // Blanco semitransparente
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {

        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
