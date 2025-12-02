namespace Proyecto_final.Formularios.Generales
{
    partial class FrmLogin
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
            Userlb = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // Userlb
            // 
            Userlb.AutoSize = true;
            Userlb.Location = new Point(68, 45);
            Userlb.Name = "Userlb";
            Userlb.Size = new Size(59, 20);
            Userlb.TabIndex = 0;
            Userlb.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(73, 83);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 131);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(76, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(70, 279);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Validar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(261, 279);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cerrar App";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(Userlb);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Userlb;
        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnCancelar;
    }
}