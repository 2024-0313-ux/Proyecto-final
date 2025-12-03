namespace Proyecto_final.Formularios.Reportes
{
    partial class FrmReporteGlobal
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
            btnGenerar = new Button();
            dgvReporteGlobal = new DataGridView();
            btnExportar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGlobal).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(78, 67);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 29);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            // 
            // dgvReporteGlobal
            // 
            dgvReporteGlobal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteGlobal.Location = new Point(78, 102);
            dgvReporteGlobal.Name = "dgvReporteGlobal";
            dgvReporteGlobal.RowHeadersWidth = 51;
            dgvReporteGlobal.Size = new Size(300, 188);
            dgvReporteGlobal.TabIndex = 1;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(84, 331);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(118, 29);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar a PDF";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(208, 331);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmReporteGlobal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnExportar);
            Controls.Add(dgvReporteGlobal);
            Controls.Add(btnGenerar);
            Name = "FrmReporteGlobal";
            Text = "FrmReporteGlobal";
            ((System.ComponentModel.ISupportInitialize)dgvReporteGlobal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerar;
        private DataGridView dgvReporteGlobal;
        private Button btnExportar;
        private Button btnCerrar;
    }
}