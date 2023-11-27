namespace CineFront.Presentacion
{
    partial class FrmClientes
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
            panelTitulo = new Panel();
            pictureClienteM = new PictureBox();
            pictureClienteH = new PictureBox();
            lblTitulo = new Label();
            panel1 = new Panel();
            dgvClientes = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColTelefono = new DataGridViewTextBoxColumn();
            ColNacimiento = new DataGridViewTextBoxColumn();
            ColQuitar = new DataGridViewButtonColumn();
            ColModificar = new DataGridViewButtonColumn();
            dataGridView1 = new DataGridView();
            panelDatos = new Panel();
            dtpClienteNacimiento = new DateTimePicker();
            mTxtClienteTel = new MaskedTextBox();
            label1 = new Label();
            lblClienteNac = new Label();
            lblClienteTel = new Label();
            lblClienteApellido = new Label();
            lblClienteNombre = new Label();
            txtClienteApellido = new TextBox();
            txtClienteNombre = new TextBox();
            panelOpciones = new Panel();
            btnVolver = new Button();
            btnInsertar = new Button();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureClienteM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureClienteH).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelDatos.SuspendLayout();
            panelOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.Transparent;
            panelTitulo.Controls.Add(pictureClienteM);
            panelTitulo.Controls.Add(pictureClienteH);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1107, 100);
            panelTitulo.TabIndex = 26;
            // 
            // pictureClienteM
            // 
            pictureClienteM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureClienteM.Image = Properties.Resources.ClienteM;
            pictureClienteM.Location = new Point(1018, 10);
            pictureClienteM.Margin = new Padding(3, 2, 3, 2);
            pictureClienteM.Name = "pictureClienteM";
            pictureClienteM.Size = new Size(80, 80);
            pictureClienteM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureClienteM.TabIndex = 5;
            pictureClienteM.TabStop = false;
            // 
            // pictureClienteH
            // 
            pictureClienteH.Image = Properties.Resources.ClienteH;
            pictureClienteH.Location = new Point(12, 10);
            pictureClienteH.Margin = new Padding(3, 2, 3, 2);
            pictureClienteH.Name = "pictureClienteH";
            pictureClienteH.Size = new Size(80, 80);
            pictureClienteH.SizeMode = PictureBoxSizeMode.Zoom;
            pictureClienteH.TabIndex = 4;
            pictureClienteH.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(333, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 47);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Gestion De Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 41, 70);
            panel1.Controls.Add(dgvClientes);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panelDatos);
            panel1.Controls.Add(panelOpciones);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 563);
            panel1.TabIndex = 6;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ColID, ColNombre, ColApellido, ColTelefono, ColNacimiento, ColQuitar, ColModificar });
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(344, 0);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(763, 503);
            dgvClientes.TabIndex = 66;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.Visible = false;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 6;
            ColNombre.Name = "ColNombre";
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.MinimumWidth = 6;
            ColApellido.Name = "ColApellido";
            // 
            // ColTelefono
            // 
            ColTelefono.HeaderText = "Telefono";
            ColTelefono.MinimumWidth = 6;
            ColTelefono.Name = "ColTelefono";
            // 
            // ColNacimiento
            // 
            ColNacimiento.HeaderText = "Nacimiento";
            ColNacimiento.MinimumWidth = 6;
            ColNacimiento.Name = "ColNacimiento";
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "Quitar";
            ColQuitar.MinimumWidth = 6;
            ColQuitar.Name = "ColQuitar";
            // 
            // ColModificar
            // 
            ColModificar.HeaderText = "Modificar";
            ColModificar.MinimumWidth = 6;
            ColModificar.Name = "ColModificar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(344, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(763, 503);
            dataGridView1.TabIndex = 63;
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.Transparent;
            panelDatos.Controls.Add(dtpClienteNacimiento);
            panelDatos.Controls.Add(mTxtClienteTel);
            panelDatos.Controls.Add(label1);
            panelDatos.Controls.Add(lblClienteNac);
            panelDatos.Controls.Add(lblClienteTel);
            panelDatos.Controls.Add(lblClienteApellido);
            panelDatos.Controls.Add(lblClienteNombre);
            panelDatos.Controls.Add(txtClienteApellido);
            panelDatos.Controls.Add(txtClienteNombre);
            panelDatos.Dock = DockStyle.Left;
            panelDatos.Location = new Point(0, 0);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(344, 503);
            panelDatos.TabIndex = 65;
            // 
            // dtpClienteNacimiento
            // 
            dtpClienteNacimiento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtpClienteNacimiento.Format = DateTimePickerFormat.Short;
            dtpClienteNacimiento.Location = new Point(149, 274);
            dtpClienteNacimiento.Name = "dtpClienteNacimiento";
            dtpClienteNacimiento.Size = new Size(146, 34);
            dtpClienteNacimiento.TabIndex = 31;
            dtpClienteNacimiento.Value = new DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // mTxtClienteTel
            // 
            mTxtClienteTel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mTxtClienteTel.Location = new Point(149, 203);
            mTxtClienteTel.Mask = "000-000-0000";
            mTxtClienteTel.Name = "mTxtClienteTel";
            mTxtClienteTel.Size = new Size(146, 34);
            mTxtClienteTel.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 29;
            label1.Text = "Cliente:";
            // 
            // lblClienteNac
            // 
            lblClienteNac.AutoSize = true;
            lblClienteNac.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNac.Location = new Point(37, 280);
            lblClienteNac.Name = "lblClienteNac";
            lblClienteNac.Size = new Size(113, 28);
            lblClienteNac.TabIndex = 28;
            lblClienteNac.Text = "Nacimiento";
            // 
            // lblClienteTel
            // 
            lblClienteTel.AutoSize = true;
            lblClienteTel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteTel.Location = new Point(37, 212);
            lblClienteTel.Name = "lblClienteTel";
            lblClienteTel.Size = new Size(86, 28);
            lblClienteTel.TabIndex = 27;
            lblClienteTel.Text = "Telefono";
            // 
            // lblClienteApellido
            // 
            lblClienteApellido.AutoSize = true;
            lblClienteApellido.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteApellido.Location = new Point(37, 144);
            lblClienteApellido.Name = "lblClienteApellido";
            lblClienteApellido.Size = new Size(86, 28);
            lblClienteApellido.TabIndex = 26;
            lblClienteApellido.Text = "Apellido";
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNombre.Location = new Point(37, 76);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(85, 28);
            lblClienteNombre.TabIndex = 25;
            lblClienteNombre.Text = "Nombre";
            // 
            // txtClienteApellido
            // 
            txtClienteApellido.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellido.Location = new Point(149, 138);
            txtClienteApellido.Name = "txtClienteApellido";
            txtClienteApellido.Size = new Size(146, 34);
            txtClienteApellido.TabIndex = 22;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteNombre.Location = new Point(149, 73);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(146, 34);
            txtClienteNombre.TabIndex = 21;
            // 
            // panelOpciones
            // 
            panelOpciones.BackColor = Color.Transparent;
            panelOpciones.Controls.Add(btnVolver);
            panelOpciones.Controls.Add(btnInsertar);
            panelOpciones.Dock = DockStyle.Bottom;
            panelOpciones.Location = new Point(0, 503);
            panelOpciones.Name = "panelOpciones";
            panelOpciones.Size = new Size(1107, 60);
            panelOpciones.TabIndex = 64;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.BackColor = Color.FromArgb(255, 68, 68);
            btnVolver.BackgroundImage = Properties.Resources.Volver;
            btnVolver.BackgroundImageLayout = ImageLayout.Zoom;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(777, 8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 40);
            btnVolver.TabIndex = 63;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInsertar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInsertar.BackColor = Color.FromArgb(255, 68, 68);
            btnInsertar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.Location = new Point(99, 8);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(130, 40);
            btnInsertar.TabIndex = 62;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 663);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmClientes_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureClienteM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureClienteH).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            panelOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTitulo;
        private Label lblTitulo;
        private PictureBox pictureClienteH;
        private Panel panel1;
        private Panel panelDatos;
        private Panel panelOpciones;
        private Button btnInsertar;
        private DataGridView dataGridView1;
        private DateTimePicker dtpClienteNacimiento;
        private MaskedTextBox mTxtClienteTel;
        private Label label1;
        private Label lblClienteNac;
        private Label lblClienteTel;
        private Label lblClienteApellido;
        private Label lblClienteNombre;
        private TextBox txtClienteApellido;
        private TextBox txtClienteNombre;
        private PictureBox pictureClienteM;
        private Button btnVolver;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColTelefono;
        private DataGridViewTextBoxColumn ColNacimiento;
        private DataGridViewButtonColumn ColQuitar;
        private DataGridViewButtonColumn ColModificar;
    }
}