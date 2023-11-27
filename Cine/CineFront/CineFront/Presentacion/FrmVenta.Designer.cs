namespace CineFront.Presentacion
{
    partial class FrmVenta
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
            panelContenedor = new Panel();
            panelDatos = new Panel();
            btnEnviar = new Button();
            btnVolver = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            dgvDetalles = new DataGridView();
            ColCliente = new DataGridViewTextBoxColumn();
            ColFilaButaca = new DataGridViewTextBoxColumn();
            ColColumnaButaca = new DataGridViewTextBoxColumn();
            ColDescuento = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            txtDescuento = new TextBox();
            lblDescuento = new Label();
            cboFormaPago = new ComboBox();
            cboCliente = new ComboBox();
            lblFormaPago = new Label();
            lblCliente = new Label();
            cboPelicula = new ComboBox();
            lblPelicula = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblventa = new Label();
            btnElegirButacas = new Button();
            panelTitulo = new Panel();
            pictureTickets = new PictureBox();
            pictureBoletería = new PictureBox();
            lblTitulo = new Label();
            ColQuitar = new DataGridViewButtonColumn();
            panelContenedor.SuspendLayout();
            panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoletería).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Transparent;
            panelContenedor.Controls.Add(panelDatos);
            panelContenedor.Controls.Add(panelTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1006, 663);
            panelContenedor.TabIndex = 0;
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.FromArgb(220, 41, 70);
            panelDatos.Controls.Add(btnEnviar);
            panelDatos.Controls.Add(btnVolver);
            panelDatos.Controls.Add(txtPrecio);
            panelDatos.Controls.Add(lblPrecio);
            panelDatos.Controls.Add(dgvDetalles);
            panelDatos.Controls.Add(btnAgregar);
            panelDatos.Controls.Add(txtDescuento);
            panelDatos.Controls.Add(lblDescuento);
            panelDatos.Controls.Add(cboFormaPago);
            panelDatos.Controls.Add(cboCliente);
            panelDatos.Controls.Add(lblFormaPago);
            panelDatos.Controls.Add(lblCliente);
            panelDatos.Controls.Add(cboPelicula);
            panelDatos.Controls.Add(lblPelicula);
            panelDatos.Controls.Add(dtpFecha);
            panelDatos.Controls.Add(lblFecha);
            panelDatos.Controls.Add(lblventa);
            panelDatos.Controls.Add(btnElegirButacas);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 100);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(1006, 563);
            panelDatos.TabIndex = 27;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnviar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEnviar.BackColor = Color.FromArgb(255, 68, 68);
            btnEnviar.BackgroundImage = Properties.Resources.Enviar;
            btnEnviar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Location = new Point(49, 495);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(262, 41);
            btnEnviar.TabIndex = 43;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVolver.BackColor = Color.FromArgb(255, 68, 68);
            btnVolver.BackgroundImage = Properties.Resources.Volver;
            btnVolver.BackgroundImageLayout = ImageLayout.Zoom;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(695, 495);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(262, 41);
            btnVolver.TabIndex = 42;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Right;
            txtPrecio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(695, 457);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(262, 34);
            txtPrecio.TabIndex = 40;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Right;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(570, 457);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 28);
            lblPrecio.TabIndex = 39;
            lblPrecio.Text = "Precio:";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalles.BackgroundColor = SystemColors.Window;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { ColCliente, ColFilaButaca, ColColumnaButaca, ColDescuento, ColPrecio, ColQuitar });
            dgvDetalles.GridColor = SystemColors.MenuText;
            dgvDetalles.Location = new Point(72, 287);
            dgvDetalles.Margin = new Padding(3, 2, 3, 2);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDetalles.RowTemplate.Height = 29;
            dgvDetalles.Size = new Size(863, 166);
            dgvDetalles.TabIndex = 36;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick_1;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.MinimumWidth = 6;
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 170;
            // 
            // ColFilaButaca
            // 
            ColFilaButaca.HeaderText = "Fila Butaca";
            ColFilaButaca.MinimumWidth = 6;
            ColFilaButaca.Name = "ColFilaButaca";
            ColFilaButaca.ReadOnly = true;
            ColFilaButaca.Width = 140;
            // 
            // ColColumnaButaca
            // 
            ColColumnaButaca.HeaderText = "Columna Butaca";
            ColColumnaButaca.MinimumWidth = 6;
            ColColumnaButaca.Name = "ColColumnaButaca";
            ColColumnaButaca.ReadOnly = true;
            ColColumnaButaca.Width = 140;
            // 
            // ColDescuento
            // 
            ColDescuento.HeaderText = "Descuento";
            ColDescuento.MinimumWidth = 6;
            ColDescuento.Name = "ColDescuento";
            ColDescuento.ReadOnly = true;
            ColDescuento.Width = 140;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 150;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left;
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.BackColor = Color.FromArgb(255, 68, 68);
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(49, 230);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(194, 37);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "Agregar Entrada";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.Right;
            txtDescuento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.Location = new Point(695, 104);
            txtDescuento.Margin = new Padding(3, 2, 3, 2);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(262, 34);
            txtDescuento.TabIndex = 32;
            // 
            // lblDescuento
            // 
            lblDescuento.Anchor = AnchorStyles.Right;
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(570, 104);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(113, 28);
            lblDescuento.TabIndex = 31;
            lblDescuento.Text = "Descuento: ";
            // 
            // cboFormaPago
            // 
            cboFormaPago.Anchor = AnchorStyles.Left;
            cboFormaPago.FlatStyle = FlatStyle.Popup;
            cboFormaPago.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(179, 154);
            cboFormaPago.Margin = new Padding(3, 2, 3, 2);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(262, 36);
            cboFormaPago.TabIndex = 30;
            // 
            // cboCliente
            // 
            cboCliente.Anchor = AnchorStyles.Right;
            cboCliente.FlatStyle = FlatStyle.Popup;
            cboCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(695, 50);
            cboCliente.Margin = new Padding(3, 2, 3, 2);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(262, 36);
            cboCliente.TabIndex = 29;
            // 
            // lblFormaPago
            // 
            lblFormaPago.Anchor = AnchorStyles.Left;
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormaPago.Location = new Point(49, 154);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(128, 28);
            lblFormaPago.TabIndex = 28;
            lblFormaPago.Text = "Forma pago: ";
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Right;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(570, 50);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(81, 28);
            lblCliente.TabIndex = 27;
            lblCliente.Text = "Cliente: ";
            // 
            // cboPelicula
            // 
            cboPelicula.Anchor = AnchorStyles.Left;
            cboPelicula.FlatStyle = FlatStyle.Popup;
            cboPelicula.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboPelicula.FormattingEnabled = true;
            cboPelicula.Location = new Point(179, 102);
            cboPelicula.Margin = new Padding(3, 2, 3, 2);
            cboPelicula.Name = "cboPelicula";
            cboPelicula.Size = new Size(262, 36);
            cboPelicula.TabIndex = 26;
            // 
            // lblPelicula
            // 
            lblPelicula.Anchor = AnchorStyles.Left;
            lblPelicula.AutoSize = true;
            lblPelicula.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPelicula.Location = new Point(49, 102);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(86, 28);
            lblPelicula.TabIndex = 25;
            lblPelicula.Text = "Película: ";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Left;
            dtpFecha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Location = new Point(179, 50);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(262, 34);
            dtpFecha.TabIndex = 24;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Left;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(49, 50);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(71, 28);
            lblFecha.TabIndex = 23;
            lblFecha.Text = "Fecha: ";
            // 
            // lblventa
            // 
            lblventa.Anchor = AnchorStyles.Left;
            lblventa.AutoSize = true;
            lblventa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblventa.Location = new Point(49, -2);
            lblventa.Name = "lblventa";
            lblventa.Size = new Size(98, 28);
            lblventa.TabIndex = 22;
            lblventa.Text = "Venta N°: ";
            // 
            // btnElegirButacas
            // 
            btnElegirButacas.Anchor = AnchorStyles.Right;
            btnElegirButacas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnElegirButacas.BackColor = Color.White;
            btnElegirButacas.BackgroundImageLayout = ImageLayout.Zoom;
            btnElegirButacas.Cursor = Cursors.Hand;
            btnElegirButacas.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnElegirButacas.FlatAppearance.BorderSize = 0;
            btnElegirButacas.FlatStyle = FlatStyle.Flat;
            btnElegirButacas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnElegirButacas.ForeColor = SystemColors.ControlText;
            btnElegirButacas.Image = Properties.Resources.ButacaDisponiblepng;
            btnElegirButacas.ImageAlign = ContentAlignment.MiddleLeft;
            btnElegirButacas.Location = new Point(570, 154);
            btnElegirButacas.Margin = new Padding(3, 2, 3, 2);
            btnElegirButacas.Name = "btnElegirButacas";
            btnElegirButacas.Size = new Size(387, 37);
            btnElegirButacas.TabIndex = 33;
            btnElegirButacas.Text = "Elegir Butacas";
            btnElegirButacas.UseVisualStyleBackColor = false;
            btnElegirButacas.Click += btnElegirButacas_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.Transparent;
            panelTitulo.Controls.Add(pictureTickets);
            panelTitulo.Controls.Add(pictureBoletería);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1006, 100);
            panelTitulo.TabIndex = 26;
            // 
            // pictureTickets
            // 
            pictureTickets.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureTickets.BackgroundImage = Properties.Resources.Tickets;
            pictureTickets.BackgroundImageLayout = ImageLayout.Stretch;
            pictureTickets.Location = new Point(914, 10);
            pictureTickets.Margin = new Padding(3, 2, 3, 2);
            pictureTickets.Name = "pictureTickets";
            pictureTickets.Size = new Size(80, 80);
            pictureTickets.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTickets.TabIndex = 5;
            pictureTickets.TabStop = false;
            // 
            // pictureBoletería
            // 
            pictureBoletería.BackgroundImage = Properties.Resources.Boleteria;
            pictureBoletería.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoletería.InitialImage = null;
            pictureBoletería.Location = new Point(12, 10);
            pictureBoletería.Margin = new Padding(3, 2, 3, 2);
            pictureBoletería.Name = "pictureBoletería";
            pictureBoletería.Size = new Size(80, 80);
            pictureBoletería.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoletería.TabIndex = 4;
            pictureBoletería.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(368, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 47);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Carga de Venta";
            // 
            // ColQuitar
            // 
            ColQuitar.HeaderText = "Quitar";
            ColQuitar.Name = "ColQuitar";
            ColQuitar.ReadOnly = true;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 663);
            ControlBox = false;
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmVentaNuevo_Load;
            panelContenedor.ResumeLayout(false);
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoletería).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelTitulo;
        private Label lblTitulo;
        private PictureBox pictureTickets;
        private PictureBox pictureBoletería;
        private Panel panelDatos;
        private Button btnAgregar;
        private TextBox txtDescuento;
        private Label lblDescuento;
        private ComboBox cboFormaPago;
        private ComboBox cboCliente;
        private Label lblFormaPago;
        private Label lblCliente;
        private ComboBox cboPelicula;
        private Label lblPelicula;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblventa;
        private DataGridView dgvDetalles;
        private Button btnElegirButacas;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Button btnVolver;
        private Button btnEnviar;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColFilaButaca;
        private DataGridViewTextBoxColumn ColColumnaButaca;
        private DataGridViewTextBoxColumn ColDescuento;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn ColQuitar;
    }
}