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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarPago));
            cboSocio = new ComboBox();
            label1 = new Label();
            cboPrestamo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtMontoPago = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            btnGuardarPago = new Button();
            btnCancelar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // cboSocio
            // 
            cboSocio.FlatStyle = FlatStyle.Flat;
            cboSocio.ForeColor = SystemColors.InfoText;
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(67, 103);
            cboSocio.Margin = new Padding(3, 2, 3, 2);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(234, 23);
            cboSocio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 82);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 1;
            label1.Text = "Socio:";
            label1.Click += label1_Click;
            // 
            // cboPrestamo
            // 
            cboPrestamo.FlatStyle = FlatStyle.Flat;
            cboPrestamo.FormattingEnabled = true;
            cboPrestamo.Location = new Point(67, 169);
            cboPrestamo.Margin = new Padding(3, 2, 3, 2);
            cboPrestamo.Name = "cboPrestamo";
            cboPrestamo.Size = new Size(234, 23);
            cboPrestamo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 3;
            label2.Text = "Prestamo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 215);
            label3.Name = "label3";
            label3.Size = new Size(102, 19);
            label3.TabIndex = 4;
            label3.Text = "Monto a pagar:";
            // 
            // txtMontoPago
            // 
            txtMontoPago.BackColor = Color.FromArgb(224, 224, 224);
            txtMontoPago.BorderStyle = BorderStyle.None;
            txtMontoPago.ForeColor = Color.Black;
            txtMontoPago.Location = new Point(67, 237);
            txtMontoPago.Margin = new Padding(3, 2, 3, 2);
            txtMontoPago.Name = "txtMontoPago";
            txtMontoPago.Size = new Size(234, 16);
            txtMontoPago.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(67, 295);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 22);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 274);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 7;
            label4.Text = "Fecha de el pago";
            // 
            // btnGuardarPago
            // 
            btnGuardarPago.BackColor = Color.SeaGreen;
            btnGuardarPago.BackgroundImageLayout = ImageLayout.None;
            btnGuardarPago.FlatStyle = FlatStyle.Flat;
            btnGuardarPago.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarPago.ForeColor = Color.White;
            btnGuardarPago.Location = new Point(57, 338);
            btnGuardarPago.Margin = new Padding(3, 2, 3, 2);
            btnGuardarPago.Name = "btnGuardarPago";
            btnGuardarPago.Size = new Size(90, 32);
            btnGuardarPago.TabIndex = 8;
            btnGuardarPago.Text = "       Pagar";
            btnGuardarPago.UseVisualStyleBackColor = false;
            btnGuardarPago.Click += btnGuardarPago_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(185, 338);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 32);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "       Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 30, 60);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGuardarPago);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(cboSocio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboPrestamo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMontoPago);
            panel1.Location = new Point(197, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 390);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(704, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 23);
            label5.Name = "label5";
            label5.Size = new Size(241, 26);
            label5.TabIndex = 10;
            label5.Text = "REGRISTRAR PAGO";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 209);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 275);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.SeaGreen;
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(67, 347);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Crimson;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(196, 348);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(22, 15);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // FrmRegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 451);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegistrarPago";
            Text = "FrmRegistrarPago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboSocio;
        private Label label1;
        private ComboBox cboPrestamo;
        private Label label2;
        private Label label3;
        private TextBox txtMontoPago;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button btnGuardarPago;
        private Button btnCancelar;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}