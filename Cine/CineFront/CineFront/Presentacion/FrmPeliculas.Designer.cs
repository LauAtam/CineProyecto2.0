using System.Windows.Forms;

namespace CineFront.Presentacion
{
    partial class FrmPeliculas
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
            panelFiltros = new Panel();
            btnBorrarFiltro = new Button();
            btnAplicar = new Button();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            flowPanelPeliculas = new FlowLayoutPanel();
            panelDatos = new Panel();
            btnVolver = new Button();
            panelTitulo = new Panel();
            pictureMovie = new PictureBox();
            pictureProyector = new PictureBox();
            lblTitulo = new Label();
            panelContenedor.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelDatos.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProyector).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Transparent;
            panelContenedor.Controls.Add(panelFiltros);
            panelContenedor.Controls.Add(flowPanelPeliculas);
            panelContenedor.Controls.Add(panelDatos);
            panelContenedor.Controls.Add(panelTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1006, 721);
            panelContenedor.TabIndex = 0;
            // 
            // panelFiltros
            // 
            panelFiltros.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFiltros.BackColor = Color.FromArgb(220, 41, 70);
            panelFiltros.Controls.Add(btnBorrarFiltro);
            panelFiltros.Controls.Add(btnAplicar);
            panelFiltros.Controls.Add(lblHasta);
            panelFiltros.Controls.Add(dtpHasta);
            panelFiltros.Controls.Add(lblDesde);
            panelFiltros.Controls.Add(dtpDesde);
            panelFiltros.Dock = DockStyle.Fill;
            panelFiltros.Location = new Point(0, 100);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(1006, 53);
            panelFiltros.TabIndex = 28;
            // 
            // btnBorrarFiltro
            // 
            btnBorrarFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBorrarFiltro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarFiltro.BackColor = Color.FromArgb(255, 68, 68);
            btnBorrarFiltro.BackgroundImageLayout = ImageLayout.Zoom;
            btnBorrarFiltro.Cursor = Cursors.Hand;
            btnBorrarFiltro.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnBorrarFiltro.FlatAppearance.BorderSize = 0;
            btnBorrarFiltro.FlatStyle = FlatStyle.Flat;
            btnBorrarFiltro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarFiltro.Location = new Point(794, 9);
            btnBorrarFiltro.Name = "btnBorrarFiltro";
            btnBorrarFiltro.Size = new Size(200, 34);
            btnBorrarFiltro.TabIndex = 44;
            btnBorrarFiltro.Text = "Borrar Filtro";
            btnBorrarFiltro.UseVisualStyleBackColor = false;
            btnBorrarFiltro.Click += btnBorrarFiltro_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAplicar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAplicar.BackColor = Color.FromArgb(255, 68, 68);
            btnAplicar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAplicar.Cursor = Cursors.Hand;
            btnAplicar.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAplicar.Location = new Point(588, 9);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(200, 34);
            btnAplicar.TabIndex = 43;
            btnAplicar.Text = "Aplicar Filtro";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.Location = new Point(304, 9);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(65, 28);
            lblHasta.TabIndex = 8;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.CustomFormat = "yyyy";
            dtpHasta.DropDownAlign = LeftRightAlignment.Right;
            dtpHasta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.Location = new Point(380, 9);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.ShowUpDown = true;
            dtpHasta.Size = new Size(200, 34);
            dtpHasta.TabIndex = 7;
            dtpHasta.Value = new DateTime(2023, 11, 27, 1, 11, 48, 515);
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.Location = new Point(22, 9);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(70, 28);
            lblDesde.TabIndex = 6;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.CustomFormat = "yyyy";
            dtpDesde.DropDownAlign = LeftRightAlignment.Right;
            dtpDesde.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.Location = new Point(98, 9);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.ShowUpDown = true;
            dtpDesde.Size = new Size(200, 34);
            dtpDesde.TabIndex = 0;
            dtpDesde.Value = new DateTime(2023, 11, 27, 1, 11, 48, 522);
            // 
            // flowPanelPeliculas
            // 
            flowPanelPeliculas.AutoScroll = true;
            flowPanelPeliculas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPanelPeliculas.Dock = DockStyle.Bottom;
            flowPanelPeliculas.Location = new Point(0, 153);
            flowPanelPeliculas.Name = "flowPanelPeliculas";
            flowPanelPeliculas.Size = new Size(1006, 508);
            flowPanelPeliculas.TabIndex = 6;
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.FromArgb(220, 41, 70);
            panelDatos.Controls.Add(btnVolver);
            panelDatos.Dock = DockStyle.Bottom;
            panelDatos.Location = new Point(0, 661);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(1006, 60);
            panelDatos.TabIndex = 27;
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
            btnVolver.Location = new Point(734, 10);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(260, 40);
            btnVolver.TabIndex = 42;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTitulo.BackColor = Color.Transparent;
            panelTitulo.Controls.Add(pictureMovie);
            panelTitulo.Controls.Add(pictureProyector);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1006, 100);
            panelTitulo.TabIndex = 26;
            // 
            // pictureMovie
            // 
            pictureMovie.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureMovie.Image = Properties.Resources.Movie;
            pictureMovie.Location = new Point(914, 10);
            pictureMovie.Margin = new Padding(3, 2, 3, 2);
            pictureMovie.Name = "pictureMovie";
            pictureMovie.Size = new Size(80, 80);
            pictureMovie.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMovie.TabIndex = 5;
            pictureMovie.TabStop = false;
            // 
            // pictureProyector
            // 
            pictureProyector.Image = Properties.Resources.Proyector;
            pictureProyector.Location = new Point(12, 10);
            pictureProyector.Margin = new Padding(3, 2, 3, 2);
            pictureProyector.Name = "pictureProyector";
            pictureProyector.Size = new Size(80, 80);
            pictureProyector.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProyector.TabIndex = 4;
            pictureProyector.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(422, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(162, 47);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Peliculas";
            // 
            // FrmPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            ControlBox = false;
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeliculas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmPeliculas_Load;
            panelContenedor.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelDatos.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProyector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelTitulo;
        private Label lblTitulo;
        private PictureBox pictureMovie;
        private Panel panelDatos;
        private Button btnVolver;
        private PictureBox pictureProyector;
        private FlowLayoutPanel flowPanelPeliculas;
        private Panel panelFiltros;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Button btnBorrarFiltro;
        private Button btnAplicar;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
    }
}