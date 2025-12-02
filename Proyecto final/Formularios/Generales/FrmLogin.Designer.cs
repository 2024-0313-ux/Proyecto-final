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
            SuspendLayout();
            // 
            // Userlb
            // 
            Userlb.AutoSize = true;
            Userlb.Location = new Point(85, 56);
            Userlb.Margin = new Padding(4, 0, 4, 0);
            Userlb.Name = "Userlb";
            Userlb.Size = new Size(72, 25);
            Userlb.TabIndex = 0;
            Userlb.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(91, 104);
            txtUsuario.Margin = new Padding(4, 4, 4, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 31);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 164);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 212);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(Userlb);
            Margin = new Padding(4, 4, 4, 4);
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
    }
}