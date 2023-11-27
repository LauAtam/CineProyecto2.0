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
            panelDatos = new Panel();
            btnComprar = new Button();
            btnVolver = new Button();
            panelTitulo = new Panel();
            pictureMovie = new PictureBox();
            pictureProyector = new PictureBox();
            lblTitulo = new Label();
            panelContenedor.SuspendLayout();
            panelDatos.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProyector).BeginInit();
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
            panelContenedor.Size = new Size(1006, 721);
            panelContenedor.TabIndex = 0;
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.FromArgb(220, 41, 70);
            panelDatos.Controls.Add(btnComprar);
            panelDatos.Controls.Add(btnVolver);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 100);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(1006, 621);
            panelDatos.TabIndex = 27;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnComprar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComprar.BackColor = Color.FromArgb(255, 68, 68);
            btnComprar.BackgroundImage = Properties.Resources.Enviar;
            btnComprar.BackgroundImageLayout = ImageLayout.Zoom;
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.Location = new Point(49, 553);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(262, 41);
            btnComprar.TabIndex = 43;
            btnComprar.Text = "Comprar Entradas";
            btnComprar.UseVisualStyleBackColor = false;
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
            btnVolver.Location = new Point(695, 553);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(262, 41);
            btnVolver.TabIndex = 42;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panelTitulo
            // 
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
            panelContenedor.ResumeLayout(false);
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
        private Button btnComprar;
        private PictureBox pictureProyector;
    }
}