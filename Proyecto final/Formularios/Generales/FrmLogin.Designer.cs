namespace Proyecto_final.Formularios.Generales
{
    partial class FrmLogin
    {
        private void Userlb_Click(object sender, EventArgs e)
        { 

        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Userlb = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Userlb
            // 
            Userlb.AutoSize = true;
            Userlb.BackColor = Color.FromArgb(0, 43, 73);
            Userlb.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userlb.ForeColor = SystemColors.Window;
            Userlb.Location = new Point(247, 132);
            Userlb.Name = "Userlb";
            Userlb.Size = new Size(68, 21);
            Userlb.TabIndex = 0;
            Userlb.Text = "Usuario";
            Userlb.Click += this.Userlb_Click; // Esta linea requiere el metodo Userlb_Click
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 43, 73);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 14.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(247, 199);
            label1.Name = "label1";
            label1.Size = new Size(99, 22);
            label1.TabIndex = 2;
            label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(0, 43, 73);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(0, 43, 73);
            txtPassword.Location = new Point(280, 235);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(126, 16);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(70, 279);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(200, 40);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Validar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(261, 279);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 26);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cerrar App";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 43, 73);
            label2.Font = new Font("Times New Roman", 20.75F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(190, 71);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 0;
            label2.Text = "INICIO DE SESIÓN";
            label2.Click += this.label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(675, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(247, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(247, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 43, 73);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.FromArgb(0, 43, 73);
            textBox1.Location = new Point(280, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 16);
            textBox1.TabIndex = 13;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(676, 447);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(Userlb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Userlb;
        private Label label1;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnCancelar;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
    }
}