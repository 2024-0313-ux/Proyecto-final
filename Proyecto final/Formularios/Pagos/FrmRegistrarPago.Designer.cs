
namespace Proyecto_final.Formularios.Pagos
{
    partial class FrmRegistrarPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cboSocio = new ComboBox();
            label1 = new Label();
            cboPrestamo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtMonto = new TextBox();
            dtpPago = new DateTimePicker();
            label4 = new Label();
            btnGuardarPago = new Button();
            btnCancelar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtMontoPendiente = new TextBox();
            SuspendLayout();
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(67, 55);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(151, 28);
            cboSocio.TabIndex = 0;
            cboSocio.SelectedIndexChanged += cboSocio_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 32);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar Socio";
            // 
            // cboPrestamo
            // 
            cboPrestamo.FormattingEnabled = true;
            cboPrestamo.Location = new Point(66, 128);
            cboPrestamo.Name = "cboPrestamo";
            cboPrestamo.Size = new Size(151, 28);
            cboPrestamo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 105);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 3;
            label2.Text = "Seleccionar prestamo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 171);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 4;
            label3.Text = "Monto a pagar";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(68, 194);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 5;
            // 
            // dtpPago
            // 
            dtpPago.Location = new Point(67, 255);
            dtpPago.Name = "dtpPago";
            dtpPago.Size = new Size(250, 27);
            dtpPago.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 232);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha de el pago";
            // 
            // btnGuardarPago
            // 
            btnGuardarPago.Location = new Point(70, 305);
            btnGuardarPago.Name = "btnGuardarPago";
            btnGuardarPago.Size = new Size(94, 29);
            btnGuardarPago.TabIndex = 8;
            btnGuardarPago.Text = "Pagar";
            btnGuardarPago.UseVisualStyleBackColor = true;
            btnGuardarPago.Click += btnPagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(193, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtMontoPendiente
            // 
            txtMontoPendiente.Location = new Point(460, 155);
            txtMontoPendiente.Name = "txtMontoPendiente";
            txtMontoPendiente.ReadOnly = true;
            txtMontoPendiente.Size = new Size(262, 27);
            txtMontoPendiente.TabIndex = 10;
            // 
            // FrmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMontoPendiente);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarPago);
            Controls.Add(label4);
            Controls.Add(dtpPago);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboPrestamo);
            Controls.Add(label1);
            Controls.Add(cboSocio);
            Name = "FrmRegistrarPago";
            Text = "FrmRegistrarPago";
            Load += FrmRegistrarPago_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private ComboBox cboSocio;
        private Label label1;
        private ComboBox cboPrestamo;
        private Label label2;
        private Label label3;
        private TextBox txtMonto;
        private DateTimePicker dtpPago;
        private Label label4;
        private Button btnGuardarPago;
        private Button btnCancelar;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtMontoPendiente;
    }
}