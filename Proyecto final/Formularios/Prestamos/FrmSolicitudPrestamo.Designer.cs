namespace Proyecto_final.Formularios.Prestamos
{
    partial class FrmSolicitudPrestamo
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
            label1 = new Label();
            txtMonto = new TextBox();
            cboSocio = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            txtPlazo = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 53);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar socio";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(42, 146);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 1;
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(42, 76);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(151, 28);
            cboSocio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 123);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 3;
            label2.Text = "Monto solicitado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 193);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Tasa de interes(%)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // txtPlazo
            // 
            txtPlazo.Location = new Point(45, 279);
            txtPlazo.Name = "txtPlazo";
            txtPlazo.Size = new Size(125, 27);
            txtPlazo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 256);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 7;
            label4.Text = "Plazo(Meses)";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(42, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(142, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 326);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 10;
            label5.Text = "Id Prestamo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 323);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // FrmSolicitudPrestamo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(txtPlazo);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboSocio);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Name = "FrmSolicitudPrestamo";
            Text = "FrmSolicitudPrestamo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMonto;
        private ComboBox cboSocio;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtPlazo;
        private Label label4;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label5;
        private TextBox textBox2;
    }
}