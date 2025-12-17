namespace Proyecto_final.Formularios.Socios
{
    partial class FrmSocioDetalle
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
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDireccion = new TextBox();
            txtCedula = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            txtCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(55, 100);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Cédula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 3;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 4;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 228);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 5;
            label5.Text = "Correo";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(55, 190);
            txtDireccion.Margin = new Padding(4, 4, 4, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(155, 31);
            txtDireccion.TabIndex = 6;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(288, 100);
            txtCedula.Margin = new Padding(4, 4, 4, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(155, 31);
            txtCedula.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(288, 190);
            txtTelefono.Margin = new Padding(4, 4, 4, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(155, 31);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(51, 256);
            txtCorreo.Margin = new Padding(4, 4, 4, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(155, 31);
            txtCorreo.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(55, 345);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 36);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCancelar
            // 
            txtCancelar.Location = new Point(254, 345);
            txtCancelar.Margin = new Padding(4, 4, 4, 4);
            txtCancelar.Name = "txtCancelar";
            txtCancelar.Size = new Size(118, 36);
            txtCancelar.TabIndex = 11;
            txtCancelar.Text = "Cancelar";
            txtCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmSocioDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(txtCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtCedula);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmSocioDetalle";
            Text = "FrmSocioDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDirección;
        private TextBox txtCédula;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button txtCancelar;
        private TextBox txtCedula;
        private TextBox txtDireccion;
    }
}