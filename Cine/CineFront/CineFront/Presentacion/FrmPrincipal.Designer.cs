namespace CineFront.Presentacion
{
    partial class FrmPrincipal
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
            panelFormularios = new Panel();
            panelBotones = new Panel();
            pictureBox1 = new PictureBox();
            btnClientes = new Button();
            btnMasVistas = new Button();
            btnVenderEntrada = new Button();
            btnPelículas = new Button();
            panelTitulo = new Panel();
            btnMinimizar = new Button();
            btnReducir = new Button();
            btnMaximizar = new Button();
            btnCerrar = new Button();
            panelContenedor.SuspendLayout();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackgroundImageLayout = ImageLayout.Stretch;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelBotones);
            panelContenedor.Controls.Add(panelTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1300, 800);
            panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            panelFormularios.BackgroundImageLayout = ImageLayout.Stretch;
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(196, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1104, 760);
            panelFormularios.TabIndex = 10;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(220, 41, 70);
            panelBotones.Controls.Add(pictureBox1);
            panelBotones.Controls.Add(btnClientes);
            panelBotones.Controls.Add(btnMasVistas);
            panelBotones.Controls.Add(btnVenderEntrada);
            panelBotones.Controls.Add(btnPelículas);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 40);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(196, 760);
            panelBotones.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Cine_Pancho_2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnClientes
            // 
            btnClientes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClientes.BackColor = Color.FromArgb(255, 68, 68);
            btnClientes.BackgroundImageLayout = ImageLayout.Zoom;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.Location = new Point(0, 307);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(196, 37);
            btnClientes.TabIndex = 9;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnMasVistas
            // 
            btnMasVistas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMasVistas.BackColor = Color.FromArgb(255, 68, 68);
            btnMasVistas.BackgroundImageLayout = ImageLayout.Zoom;
            btnMasVistas.Cursor = Cursors.Hand;
            btnMasVistas.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnMasVistas.FlatAppearance.BorderSize = 0;
            btnMasVistas.FlatStyle = FlatStyle.Flat;
            btnMasVistas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMasVistas.Location = new Point(0, 270);
            btnMasVistas.Name = "btnMasVistas";
            btnMasVistas.Size = new Size(196, 37);
            btnMasVistas.TabIndex = 8;
            btnMasVistas.Text = "Peliculas más vistas";
            btnMasVistas.UseVisualStyleBackColor = false;
            btnMasVistas.Click += btnMasVistas_Click;
            // 
            // btnVenderEntrada
            // 
            btnVenderEntrada.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVenderEntrada.BackColor = Color.FromArgb(255, 68, 68);
            btnVenderEntrada.BackgroundImageLayout = ImageLayout.Zoom;
            btnVenderEntrada.Cursor = Cursors.Hand;
            btnVenderEntrada.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnVenderEntrada.FlatAppearance.BorderSize = 0;
            btnVenderEntrada.FlatStyle = FlatStyle.Flat;
            btnVenderEntrada.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenderEntrada.Location = new Point(0, 233);
            btnVenderEntrada.Name = "btnVenderEntrada";
            btnVenderEntrada.Size = new Size(196, 37);
            btnVenderEntrada.TabIndex = 7;
            btnVenderEntrada.Text = "Vender Entrada";
            btnVenderEntrada.UseVisualStyleBackColor = false;
            btnVenderEntrada.Click += btnVenderEntrada_Click;
            // 
            // btnPelículas
            // 
            btnPelículas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPelículas.BackColor = Color.FromArgb(255, 68, 68);
            btnPelículas.BackgroundImageLayout = ImageLayout.Zoom;
            btnPelículas.Cursor = Cursors.Hand;
            btnPelículas.FlatAppearance.BorderColor = Color.FromArgb(255, 17, 17);
            btnPelículas.FlatAppearance.BorderSize = 0;
            btnPelículas.FlatStyle = FlatStyle.Flat;
            btnPelículas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPelículas.Location = new Point(0, 196);
            btnPelículas.Name = "btnPelículas";
            btnPelículas.Size = new Size(196, 37);
            btnPelículas.TabIndex = 5;
            btnPelículas.Text = "Peliculas";
            btnPelículas.UseVisualStyleBackColor = false;
            btnPelículas.Click += btnPelículas_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(62, 3, 12);
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(btnReducir);
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1300, 40);
            panelTitulo.TabIndex = 0;
            panelTitulo.MouseMove += panelTitulo_MouseMove;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMinimizar.BackColor = Color.FromArgb(62, 3, 12);
            btnMinimizar.BackgroundImage = Properties.Resources.Minimizar2;
            btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderColor = Color.FromArgb(29, 3, 8);
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(1195, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.TabIndex = 4;
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnReducir
            // 
            btnReducir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReducir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReducir.BackColor = Color.FromArgb(62, 3, 12);
            btnReducir.BackgroundImage = Properties.Resources.Reducir;
            btnReducir.BackgroundImageLayout = ImageLayout.Zoom;
            btnReducir.Cursor = Cursors.Hand;
            btnReducir.FlatAppearance.BorderColor = Color.FromArgb(29, 3, 8);
            btnReducir.FlatAppearance.BorderSize = 0;
            btnReducir.FlatStyle = FlatStyle.Flat;
            btnReducir.Location = new Point(1231, 3);
            btnReducir.Name = "btnReducir";
            btnReducir.Size = new Size(30, 30);
            btnReducir.TabIndex = 3;
            btnReducir.UseVisualStyleBackColor = false;
            btnReducir.Visible = false;
            btnReducir.Click += btnReducir_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMaximizar.BackColor = Color.FromArgb(62, 3, 12);
            btnMaximizar.BackgroundImage = Properties.Resources.Maximizar;
            btnMaximizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.FlatAppearance.BorderColor = Color.FromArgb(29, 3, 8);
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Location = new Point(1231, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 30);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCerrar.BackColor = Color.FromArgb(62, 3, 12);
            btnCerrar.BackgroundImage = Properties.Resources.Cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(29, 3, 8);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1267, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.TabIndex = 1;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 800);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1080, 710);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            panelContenedor.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelTitulo;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Button btnReducir;
        private Button btnMaximizar;
        private Panel panelBotones;
        private Button btnPelículas;
        private Button btnClientes;
        private Button btnMasVistas;
        private Button btnVenderEntrada;
        private Panel panelFormularios;
        private PictureBox pictureBox1;
    }
}