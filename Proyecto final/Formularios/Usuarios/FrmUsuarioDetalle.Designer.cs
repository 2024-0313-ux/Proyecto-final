namespace Proyecto_final.Formularios.Usuarios
{
    partial class FrmUsuarioDetalle
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
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            cboRol = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(134, 39);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(277, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(190, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(277, 83);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(190, 27);
            txtCorreo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(134, 82);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 3;
            label2.Text = "Correo:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(134, 125);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(277, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 27);
            txtPassword.TabIndex = 5;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(277, 168);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(190, 28);
            cboRol.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(134, 168);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 7;
            label4.Text = "Rol:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 43, 73);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(32, 270);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 43, 73);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(156, 270);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._597644960_1230125715660992_2151207350931552615_n;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboRol);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(85, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 320);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 43, 73);
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(279, 19);
            label5.Name = "label5";
            label5.Size = new Size(242, 32);
            label5.TabIndex = 12;
            label5.Text = "Detalle del Usuario";
            label5.Click += label5_Click;
            // 
            // FrmUsuarioDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FrmUsuarioDetalle";
            Text = "FrmUsuarioDetalle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private ComboBox cboRol;
        private Label label4;
        private Button button1;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
    }
}