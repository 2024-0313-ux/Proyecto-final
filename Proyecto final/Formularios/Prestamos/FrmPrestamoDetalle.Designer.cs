namespace Proyecto_final.Formularios.Prestamos
{
    partial class FrmPrestamoDetalle
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
            dgvPagos = new DataGridView();
            label2 = new Label();
            btnPago = new Button();
            Label24 = new Label();
            lblSocio = new Label();
            lblMonto = new Label();
            lblTasa = new Label();
            lblPlazos = new Label();
            label3 = new Label();
            lblIdPrestamo = new Label();
            lblSaldoPendiente = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 88);
            label1.Name = "label1";
            label1.Size = new Size(56, 80);
            label1.TabIndex = 0;
            label1.Text = "Socio:\r\nMonto:\r\nTasa:\r\nPlazos:\r\n";
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(83, 175);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowHeadersWidth = 51;
            dgvPagos.Size = new Size(300, 188);
            dgvPagos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 378);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "Saldo pendiente:";
            // 
            // btnPago
            // 
            btnPago.Location = new Point(407, 374);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(121, 29);
            btnPago.TabIndex = 3;
            btnPago.Text = "Registrar pago";
            btnPago.UseVisualStyleBackColor = true;
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Location = new Point(83, 398);
            Label24.Name = "Label24";
            Label24.Size = new Size(45, 20);
            Label24.TabIndex = 4;
            Label24.Text = "Total:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(145, 88);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(64, 20);
            lblSocio.TabIndex = 5;
            lblSocio.Text = "Nombre";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(145, 108);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(53, 20);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "Monto";
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(145, 128);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(37, 20);
            lblTasa.TabIndex = 7;
            lblTasa.Text = "Tasa";
            // 
            // lblPlazos
            // 
            lblPlazos.AutoSize = true;
            lblPlazos.Location = new Point(145, 148);
            lblPlazos.Name = "lblPlazos";
            lblPlazos.Size = new Size(51, 20);
            lblPlazos.TabIndex = 8;
            lblPlazos.Text = "Plazos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 55);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 9;
            label3.Text = "ID Prestamo";
            // 
            // lblIdPrestamo
            // 
            lblIdPrestamo.AutoSize = true;
            lblIdPrestamo.Location = new Point(182, 55);
            lblIdPrestamo.Name = "lblIdPrestamo";
            lblIdPrestamo.Size = new Size(0, 20);
            lblIdPrestamo.TabIndex = 10;
            // 
            // lblSaldoPendiente
            // 
            lblSaldoPendiente.AutoSize = true;
            lblSaldoPendiente.Location = new Point(210, 378);
            lblSaldoPendiente.Name = "lblSaldoPendiente";
            lblSaldoPendiente.Size = new Size(0, 20);
            lblSaldoPendiente.TabIndex = 11;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(210, 398);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 12;
            // 
            // FrmPrestamoDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblSaldoPendiente);
            Controls.Add(lblIdPrestamo);
            Controls.Add(label3);
            Controls.Add(lblPlazos);
            Controls.Add(lblTasa);
            Controls.Add(lblMonto);
            Controls.Add(lblSocio);
            Controls.Add(Label24);
            Controls.Add(btnPago);
            Controls.Add(label2);
            Controls.Add(dgvPagos);
            Controls.Add(label1);
            Name = "FrmPrestamoDetalle";
            Text = "FrmPrestamoDetalle";
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPagos;
        private Label label2;
        private Button btnPago;
        private Label Label24;
        private Label lblSocio;
        private Label lblMonto;
        private Label lblTasa;
        private Label lblPlazos;
        private Label label3;
        private Label lblIdPrestamo;
        private Label lblSaldoPendiente;
        private Label lblTotal;
    }
}