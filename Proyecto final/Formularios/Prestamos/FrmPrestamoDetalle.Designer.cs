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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamoDetalle));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            colPlazos = new DataGridViewTextBoxColumn();
            colTasa = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dgvPagos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 143);
            label1.Name = "label1";
            label1.Size = new Size(49, 68);
            label1.TabIndex = 0;
            label1.Text = "Socio:\r\nMonto:\r\nTasa:\r\nPlazos:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 439);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 2;
            label2.Text = "Saldo pendiente:";
            label2.Click += label2_Click;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.FromArgb(46, 204, 113);
            btnPago.BackgroundImageLayout = ImageLayout.None;
            btnPago.FlatAppearance.BorderSize = 0;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPago.ForeColor = Color.WhiteSmoke;
            btnPago.Location = new Point(476, 448);
            btnPago.Margin = new Padding(3, 2, 3, 2);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(178, 33);
            btnPago.TabIndex = 3;
            btnPago.Text = "       Registrar pago";
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnPago_Click;
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.FlatStyle = FlatStyle.Flat;
            Label24.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label24.ForeColor = Color.White;
            Label24.Location = new Point(27, 458);
            Label24.Name = "Label24";
            Label24.Size = new Size(42, 19);
            Label24.TabIndex = 4;
            Label24.Text = "Total:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.FlatStyle = FlatStyle.Flat;
            lblSocio.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSocio.ForeColor = Color.White;
            lblSocio.Location = new Point(135, 143);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(56, 17);
            lblSocio.TabIndex = 5;
            lblSocio.Text = "Nombre";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.ForeColor = Color.White;
            lblMonto.Location = new Point(135, 160);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 17);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "Monto";
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.FlatStyle = FlatStyle.Flat;
            lblTasa.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTasa.ForeColor = Color.White;
            lblTasa.Location = new Point(135, 177);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(36, 17);
            lblTasa.TabIndex = 7;
            lblTasa.Text = "Tasa";
            // 
            // lblPlazos
            // 
            lblPlazos.AutoSize = true;
            lblPlazos.FlatStyle = FlatStyle.Flat;
            lblPlazos.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlazos.ForeColor = Color.White;
            lblPlazos.Location = new Point(135, 194);
            lblPlazos.Name = "lblPlazos";
            lblPlazos.Size = new Size(46, 17);
            lblPlazos.TabIndex = 8;
            lblPlazos.Text = "Plazos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 115);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 9;
            label3.Text = "ID Prestamo";
            label3.Click += label3_Click;
            // 
            // lblIdPrestamo
            // 
            lblIdPrestamo.AutoSize = true;
            lblIdPrestamo.Location = new Point(159, 41);
            lblIdPrestamo.Name = "lblIdPrestamo";
            lblIdPrestamo.Size = new Size(0, 15);
            lblIdPrestamo.TabIndex = 10;
            // 
            // lblSaldoPendiente
            // 
            lblSaldoPendiente.AutoSize = true;
            lblSaldoPendiente.Location = new Point(184, 284);
            lblSaldoPendiente.Name = "lblSaldoPendiente";
            lblSaldoPendiente.Size = new Size(0, 15);
            lblSaldoPendiente.TabIndex = 11;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(184, 298);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblSocio);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(Label24);
            panel1.Controls.Add(lblPlazos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnPago);
            panel1.Controls.Add(lblTasa);
            panel1.Controls.Add(dgvPagos);
            panel1.Location = new Point(83, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 502);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(46, 204, 113);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(501, 455);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(200, 57);
            label4.Name = "label4";
            label4.Size = new Size(300, 27);
            label4.TabIndex = 10;
            label4.Text = "DETALLE DEL PRESTAMO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(869, 552);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // colPlazos
            // 
            colPlazos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colPlazos.DefaultCellStyle = dataGridViewCellStyle6;
            colPlazos.HeaderText = "Plazos";
            colPlazos.Name = "colPlazos";
            colPlazos.ReadOnly = true;
            // 
            // colTasa
            // 
            colTasa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colTasa.DefaultCellStyle = dataGridViewCellStyle5;
            colTasa.HeaderText = "Tasa";
            colTasa.Name = "colTasa";
            colTasa.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colMonto.DefaultCellStyle = dataGridViewCellStyle4;
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colNombre.DefaultCellStyle = dataGridViewCellStyle3;
            colNombre.HeaderText = "Nombre ";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.HeaderText = "ID Préstamo";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToDeleteRows = false;
            dgvPagos.AllowUserToOrderColumns = true;
            dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagos.BackgroundColor = Color.FromArgb(10, 30, 60);
            dgvPagos.BorderStyle = BorderStyle.None;
            dgvPagos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 90, 150);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 90, 150);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { Column1, colId, colNombre, colMonto, colTasa, colPlazos });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(10, 30, 60);
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvPagos.DefaultCellStyle = dataGridViewCellStyle7;
            dgvPagos.EnableHeadersVisualStyles = false;
            dgvPagos.GridColor = Color.FromArgb(40, 60, 90);
            dgvPagos.Location = new Point(17, 222);
            dgvPagos.Margin = new Padding(3, 2, 3, 2);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(10, 30, 60);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvPagos.RowHeadersVisible = false;
            dgvPagos.RowHeadersWidth = 51;
            dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagos.Size = new Size(665, 205);
            dgvPagos.TabIndex = 1;
            dgvPagos.CellContentClick += dgvPagos_CellContentClick;
            // 
            // FrmPrestamoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 551);
            Controls.Add(panel1);
            Controls.Add(lblTotal);
            Controls.Add(lblSaldoPendiente);
            Controls.Add(lblIdPrestamo);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPrestamoDetalle";
            Text = "FrmPrestamoDetalle";
            Load += FrmPrestamoDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgvPagos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colTasa;
        private DataGridViewTextBoxColumn colPlazos;
    }
}