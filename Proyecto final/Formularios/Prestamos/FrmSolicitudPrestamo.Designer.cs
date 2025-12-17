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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudPrestamo));
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 119);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar socio";
            label1.Click += label1_Click;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(10, 30, 60);
            txtMonto.BorderStyle = BorderStyle.None;
            txtMonto.ForeColor = Color.White;
            txtMonto.Location = new Point(37, 200);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(110, 16);
            txtMonto.TabIndex = 1;
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(32, 140);
            cboSocio.Margin = new Padding(3, 2, 3, 2);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(432, 23);
            cboSocio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 179);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 3;
            label2.Text = "Monto solicitado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 241);
            label3.Name = "label3";
            label3.Size = new Size(122, 19);
            label3.TabIndex = 4;
            label3.Text = "Tasa de interes(%)";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(10, 30, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(37, 262);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 16);
            textBox1.TabIndex = 5;
            // 
            // txtPlazo
            // 
            txtPlazo.BackColor = Color.FromArgb(10, 30, 60);
            txtPlazo.BorderStyle = BorderStyle.None;
            txtPlazo.Location = new Point(37, 332);
            txtPlazo.Margin = new Padding(3, 2, 3, 2);
            txtPlazo.Name = "txtPlazo";
            txtPlazo.Size = new Size(110, 16);
            txtPlazo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 311);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 7;
            label4.Text = "Plazo(Meses)";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(112, 451);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Solicitud";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(276, 451);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 380);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 10;
            label5.Text = "Id Prestamo";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(10, 30, 60);
            textBox2.Location = new Point(37, 401);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(427, 23);
            textBox2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(835, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 30, 60);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cboSocio);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPlazo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(174, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 41);
            label6.Name = "label6";
            label6.Size = new Size(343, 31);
            label6.TabIndex = 12;
            label6.Text = "SOLICITUD DE PRÉSTAMO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(37, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 1);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(37, 283);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 1);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(37, 353);
            panel4.Name = "panel4";
            panel4.Size = new Size(420, 1);
            panel4.TabIndex = 15;
            // 
            // FrmSolicitudPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 560);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmSolicitudPrestamo";
            Text = "FrmSolicitudPrestamo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
    }
}