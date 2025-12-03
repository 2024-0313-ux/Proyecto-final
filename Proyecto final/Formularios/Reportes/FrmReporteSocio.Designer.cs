namespace Proyecto_final.Formularios.Reportes
{
    partial class FrmReporteSocio
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
            cboSocio = new ComboBox();
            btnGenerar = new Button();
            dgvReporte = new DataGridView();
            btnExportar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(48, 47);
            cboSocio.Margin = new Padding(2);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(146, 28);
            cboSocio.TabIndex = 0;
            cboSocio.SelectedIndexChanged += cboSocio_SelectedIndexChanged;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(45, 79);
            btnGenerar.Margin = new Padding(2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(90, 27);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += this.btnGenerar_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(48, 110);
            dgvReporte.Margin = new Padding(2);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 62;
            dgvReporte.Size = new Size(288, 180);
            dgvReporte.TabIndex = 2;
            dgvReporte.CellContentClick += this.dgvReporte_CellContentClick;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(36, 291);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(116, 27);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += button2_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(231, 291);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 27);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += this.btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 16);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 5;
            label1.Text = "Selelccione un socio";
            label1.Click += this.label1_Click;
            // 
            // FrmReporteSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 393);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnExportar);
            Controls.Add(dgvReporte);
            Controls.Add(btnGenerar);
            Controls.Add(cboSocio);
            Margin = new Padding(2);
            Name = "FrmReporteSocio";
            Text = "FrmReporteSocio";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSocio;
        private Button btnGenerar;
        private DataGridView dgvReporte;
        private Button btnExportar;
        private Button btnCerrar;
        private Label label1;
    }
}