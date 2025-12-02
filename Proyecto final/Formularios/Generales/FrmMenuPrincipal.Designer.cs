namespace Proyecto_final.Formularios.Generales
{
    partial class FrmMenuPrincipal
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
            btmSocios = new Button();
            btnAportes = new Button();
            btnPrestamos = new Button();
            btnPagos = new Button();
            btnReportes = new Button();
            btnUsuarios = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 33);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Sistema Cooperativa";
            // 
            // btmSocios
            // 
            btmSocios.Location = new Point(32, 93);
            btmSocios.Name = "btmSocios";
            btmSocios.Size = new Size(94, 29);
            btmSocios.TabIndex = 1;
            btmSocios.Text = "Socios";
            btmSocios.UseVisualStyleBackColor = true;
            // 
            // btnAportes
            // 
            btnAportes.Location = new Point(32, 128);
            btnAportes.Name = "btnAportes";
            btnAportes.Size = new Size(94, 29);
            btnAportes.TabIndex = 2;
            btnAportes.Text = "Reg aporte";
            btnAportes.UseVisualStyleBackColor = true;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Location = new Point(32, 163);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(94, 29);
            btnPrestamos.TabIndex = 3;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(32, 198);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(98, 29);
            btnPagos.TabIndex = 4;
            btnPagos.Text = "Hacer pago";
            btnPagos.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(32, 233);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 29);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(32, 268);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(94, 29);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(314, 339);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(144, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Cerrar Sesión";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnUsuarios);
            Controls.Add(btnReportes);
            Controls.Add(btnPagos);
            Controls.Add(btnPrestamos);
            Controls.Add(btnAportes);
            Controls.Add(btmSocios);
            Controls.Add(label1);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btmSocios;
        private Button btnAportes;
        private Button btnPrestamos;
        private Button btnPagos;
        private Button btnReportes;
        private Button btnUsuarios;
        private Button btnSalir;
    }
}