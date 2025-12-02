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
            label1 = new Label();
            cboSocio = new ComboBox();
            label2 = new Label();
            txtMonto = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            Guardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 39);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar socio";
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(59, 62);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(151, 28);
            cboSocio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 108);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(59, 131);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 180);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(59, 203);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(295, 27);
            dtpFecha.TabIndex = 5;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(60, 263);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(94, 29);
            Guardar.TabIndex = 6;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(218, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrarAporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(Guardar);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(cboSocio);
            Controls.Add(label1);
            Name = "FrmRegistrarAporte";
            Text = "FrmRegistrarAporte";
            ResumeLayout(false);
            PerformLayout();
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
    }
}