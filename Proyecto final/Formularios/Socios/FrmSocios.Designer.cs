namespace Proyecto_final.Formularios.Socios
{
    partial class FrmSocios
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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvSocios = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            ColId = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColMembresia = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 43, 73);
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 24);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar Socios";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(0, 43, 73);
            txtBuscar.ForeColor = SystemColors.Window;
            txtBuscar.Location = new Point(43, 61);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(180, 27);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 43, 73);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Control;
            btnBuscar.Location = new Point(43, 101);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvSocios
            // 
            dgvSocios.BackgroundColor = Color.FromArgb(0, 43, 73);
            dgvSocios.BorderStyle = BorderStyle.Fixed3D;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Columns.AddRange(new DataGridViewColumn[] { ColId, ColNombre, ColApellido, ColMembresia, ColEstado });
            dgvSocios.GridColor = Color.FromArgb(0, 43, 73);
            dgvSocios.Location = new Point(43, 136);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.RowHeadersWidth = 51;
            dgvSocios.Size = new Size(675, 248);
            dgvSocios.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 43, 73);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonFace;
            btnAgregar.Location = new Point(43, 390);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 43, 73);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Location = new Point(163, 390);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(0, 43, 73);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(285, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._597644960_1230125715660992_2151207350931552615_n;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.Width = 125;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            ColNombre.Width = 125;
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.MinimumWidth = 6;
            ColApellido.Name = "ColApellido";
            ColApellido.Width = 125;
            // 
            // ColMembresia
            // 
            ColMembresia.HeaderText = "Membresia";
            ColMembresia.MinimumWidth = 6;
            ColMembresia.Name = "ColMembresia";
            ColMembresia.Width = 125;
            // 
            // ColEstado
            // 
            ColEstado.HeaderText = "Estado";
            ColEstado.MinimumWidth = 6;
            ColEstado.Name = "ColEstado";
            ColEstado.Width = 125;
            // 
            // FrmSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvSocios);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmSocios";
            Text = "FrmSocios";
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvSocios;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColMembresia;
        private DataGridViewTextBoxColumn ColEstado;
    }
}