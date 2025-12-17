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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteGlobal));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCerrar = new Button();
            btnGenerar = new Button();
            btnExportar = new Button();
            dgvReporteGlobal = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = Properties.Resources._597644960_1230125715660992_2151207350931552615_n;
            pictureBox1.Location = new Point(3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(796, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 43, 73);
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 22);
            label1.Name = "label1";
            label1.Size = new Size(278, 32);
            label1.TabIndex = 6;
            label1.Text = "REPORTE GLOBAL";
            label1.Click += label1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(0, 43, 73);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(246, 383);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(101, 55);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(0, 43, 73);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = SystemColors.ButtonFace;
            btnGenerar.Location = new Point(78, 81);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 29);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.DarkRed;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(78, 383);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(152, 55);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar a";
            btnExportar.TextAlign = ContentAlignment.MiddleLeft;
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // dgvReporteGlobal
            // 
            dgvReporteGlobal.BackgroundColor = Color.FromArgb(0, 43, 73);
            dgvReporteGlobal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteGlobal.Location = new Point(78, 116);
            dgvReporteGlobal.Name = "dgvReporteGlobal";
            dgvReporteGlobal.RowHeadersWidth = 51;
            dgvReporteGlobal.Size = new Size(652, 246);
            dgvReporteGlobal.TabIndex = 1;
            dgvReporteGlobal.CellContentClick += dgvReporteGlobal_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 392);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(332, 184);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // FrmReporteGlobal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(dgvReporteGlobal);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnExportar);
            Controls.Add(btnGenerar);
            Controls.Add(pictureBox1);
            Name = "FrmReporteGlobal";
            Text = "FrmReporteGlobal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGlobal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnCerrar;
        private Button btnGenerar;
        private Button btnExportar;
        private DataGridView dgvReporteGlobal;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}