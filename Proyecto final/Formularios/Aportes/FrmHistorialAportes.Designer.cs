namespace Proyecto_final.Formularios.Aportes
{
    partial class FrmHistorialAportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialAportes));
            label1 = new Label();
            cboSocio = new ComboBox();
            btnMostrar = new Button();
            label2 = new Label();
            lblTotal = new Label();
            label3 = new Label();
            dgvAportes = new DataGridView();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 43, 73);
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(149, 61);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar socio";
            label1.Click += label1_Click;
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(280, 59);
            cboSocio.Margin = new Padding(3, 2, 3, 2);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(133, 23);
            cboSocio.TabIndex = 1;
            cboSocio.SelectedIndexChanged += cboSocio_SelectedIndexChanged;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.FromArgb(0, 43, 73);
            btnMostrar.FlatStyle = FlatStyle.Popup;
            btnMostrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = Color.White;
            btnMostrar.Location = new Point(419, 57);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(82, 23);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 43, 73);
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(149, 258);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "Total ahorrado:";
            label2.Click += label2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(0, 43, 73);
            lblTotal.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.ForestGreen;
            lblTotal.Location = new Point(257, 258);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "IblTotal";
            lblTotal.Click += lblTotal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 113);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            label3.Click += label3_Click;
            // 
            // dgvAportes
            // 
            dgvAportes.AllowUserToAddRows = false;
            dgvAportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAportes.Location = new Point(149, 95);
            dgvAportes.Name = "dgvAportes";
            dgvAportes.ReadOnly = true;
            dgvAportes.RowHeadersVisible = false;
            dgvAportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAportes.Size = new Size(352, 150);
            dgvAportes.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 43, 73);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(248, 22);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 8;
            label4.Text = "Historial de Aportes";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(631, 334);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmHistorialAportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(630, 338);
            Controls.Add(label4);
            Controls.Add(dgvAportes);
            Controls.Add(label3);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(cboSocio);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHistorialAportes";
            Text = "Frm";
            Load += FrmHistorialAportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboSocio;
        private Button btnMostrar;
        private Label label2;
        private Label lblTotal;
        private Label label3;
        private DataGridView dgvAportes;
        private Label label4;
        private PictureBox pictureBox1;
    }
}