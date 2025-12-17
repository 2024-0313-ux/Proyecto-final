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
            cmbSocios = new ComboBox();
            btnGenerar = new Button();
            dgvReporte = new DataGridView();
            btnExportar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // cmbSocios
            // 
            cmbSocios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSocios.DropDownWidth = 250;
            cmbSocios.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSocios.FormattingEnabled = true;
            cmbSocios.Location = new Point(183, 185);
            cmbSocios.Margin = new Padding(2);
            cmbSocios.Name = "cmbSocios";
            cmbSocios.Size = new Size(128, 27);
            cmbSocios.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.RoyalBlue;
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(183, 216);
            btnGenerar.Margin = new Padding(2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(144, 29);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // dgvReporte
            // 
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(253, 270);
            dgvReporte.Margin = new Padding(2);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 62;
            dgvReporte.Size = new Size(252, 135);
            dgvReporte.TabIndex = 2;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(39, 409);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(102, 20);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(489, 409);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(79, 20);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 129);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 5;
            label1.Text = "Selelccione un socio";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(234, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(372, 36);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Reporte Individual de Socio";
            // 
            // FrmReporteSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnExportar);
            Controls.Add(dgvReporte);
            Controls.Add(btnGenerar);
            Controls.Add(cmbSocios);
            Margin = new Padding(2);
            Name = "FrmReporteSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Socio";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSocios;
        private Button btnGenerar;
        private DataGridView dgvReporte;
        private Button btnExportar;
        private Button btnCerrar;
        private Label label1;
        private Label lblTitulo;
    }
}