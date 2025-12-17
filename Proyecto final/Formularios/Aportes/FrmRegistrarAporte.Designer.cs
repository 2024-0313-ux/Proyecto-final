namespace Proyecto_final.Formularios.Aportes
{
    partial class FrmRegistrarAporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarAporte));
            label1 = new Label();
            cboSocio = new ComboBox();
            label2 = new Label();
            txtMonto = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            Guardar = new Button();
            btnCancelar = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 69);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar socio:";
            label1.Click += label1_Click;
            // 
            // cboSocio
            // 
            cboSocio.FlatStyle = FlatStyle.Flat;
            cboSocio.Font = new Font("Segoe UI", 10F);
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(34, 90);
            cboSocio.Margin = new Padding(3, 2, 3, 2);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(320, 25);
            cboSocio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 127);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 2;
            label2.Text = "Monto:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(34, 148);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(80, 23);
            txtMonto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 187);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 4;
            label3.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(34, 208);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(259, 23);
            dtpFecha.TabIndex = 5;
            // 
            // Guardar
            // 
            Guardar.BackColor = Color.SeaGreen;
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guardar.ForeColor = Color.White;
            Guardar.Location = new Point(85, 244);
            Guardar.Margin = new Padding(3, 2, 3, 2);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(82, 35);
            Guardar.TabIndex = 6;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Crimson;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(198, 244);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(704, 341);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 30, 60);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Guardar);
            panel1.Controls.Add(cboSocio);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMonto);
            panel1.Location = new Point(148, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 286);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(97, 25);
            label4.Name = "label4";
            label4.Size = new Size(218, 22);
            label4.TabIndex = 0;
            label4.Text = "REGISTRAR APORTES";
            // 
            // FrmRegistrarAporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegistrarAporte";
            Text = "FrmRegistrarAporte";
            Load += FrmRegistrarAporte_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboSocio;
        private Label label2;
        private TextBox txtMonto;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Button Guardar;
        private Button btnCancelar;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label4;
    }
}