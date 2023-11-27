namespace CineFront.Presentacion
{
    partial class ItemPelicula
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenedor = new Panel();
            lblAudio = new Label();
            lblSubtitulos = new Label();
            lblGenero = new Label();
            lblAño = new Label();
            lblTitulo = new Label();
            lblSinopsis = new Label();
            picturePortada = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePortada).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(lblAudio);
            panelContenedor.Controls.Add(lblSubtitulos);
            panelContenedor.Controls.Add(lblGenero);
            panelContenedor.Controls.Add(lblAño);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(lblSinopsis);
            panelContenedor.Controls.Add(picturePortada);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1100, 196);
            panelContenedor.TabIndex = 0;
            panelContenedor.MouseEnter += ItemPelicula_MouseEnter;
            panelContenedor.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // lblAudio
            // 
            lblAudio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAudio.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            lblAudio.Location = new Point(126, 129);
            lblAudio.MaximumSize = new Size(381, 61);
            lblAudio.Name = "lblAudio";
            lblAudio.Size = new Size(377, 34);
            lblAudio.TabIndex = 19;
            lblAudio.Text = "Audio: ";
            lblAudio.MouseEnter += ItemPelicula_MouseEnter;
            lblAudio.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // lblSubtitulos
            // 
            lblSubtitulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulos.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            lblSubtitulos.Location = new Point(126, 163);
            lblSubtitulos.MaximumSize = new Size(381, 61);
            lblSubtitulos.Name = "lblSubtitulos";
            lblSubtitulos.Size = new Size(377, 34);
            lblSubtitulos.TabIndex = 18;
            lblSubtitulos.Text = "Subtitulos: ";
            lblSubtitulos.MouseEnter += ItemPelicula_MouseEnter;
            lblSubtitulos.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // lblGenero
            // 
            lblGenero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGenero.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            lblGenero.Location = new Point(126, 95);
            lblGenero.MaximumSize = new Size(381, 61);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(377, 34);
            lblGenero.TabIndex = 17;
            lblGenero.Text = "Género: ";
            lblGenero.MouseEnter += ItemPelicula_MouseEnter;
            lblGenero.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // lblAño
            // 
            lblAño.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAño.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            lblAño.Location = new Point(126, 61);
            lblAño.MaximumSize = new Size(381, 61);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(377, 34);
            lblAño.TabIndex = 16;
            lblAño.Text = "Año: ";
            lblAño.MouseEnter += ItemPelicula_MouseEnter;
            lblAño.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(126, 0);
            lblTitulo.MaximumSize = new Size(381, 61);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(377, 61);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Titulo: ";
            lblTitulo.MouseEnter += ItemPelicula_MouseEnter;
            lblTitulo.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // lblSinopsis
            // 
            lblSinopsis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSinopsis.BackColor = Color.Transparent;
            lblSinopsis.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSinopsis.Location = new Point(513, 0);
            lblSinopsis.Name = "lblSinopsis";
            lblSinopsis.Size = new Size(589, 196);
            lblSinopsis.TabIndex = 14;
            lblSinopsis.Text = "Sinopsis";
            lblSinopsis.MouseEnter += ItemPelicula_MouseEnter;
            lblSinopsis.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // picturePortada
            // 
            picturePortada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picturePortada.BackgroundImageLayout = ImageLayout.Stretch;
            picturePortada.Location = new Point(0, 0);
            picturePortada.Name = "picturePortada";
            picturePortada.Size = new Size(125, 196);
            picturePortada.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePortada.TabIndex = 7;
            picturePortada.TabStop = false;
            picturePortada.MouseEnter += ItemPelicula_MouseEnter;
            picturePortada.MouseLeave += ItemPelicula_MouseLeave;
            // 
            // ItemPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(panelContenedor);
            Margin = new Padding(5);
            Name = "ItemPelicula";
            Size = new Size(1100, 196);
            MouseEnter += ItemPelicula_MouseEnter;
            MouseLeave += ItemPelicula_MouseLeave;
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePortada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private PictureBox picturePortada;
        private Label lblSinopsis;
        private Label lblTitulo;
        private Label lblAudio;
        private Label lblSubtitulos;
        private Label lblGenero;
        private Label lblAño;
    }
}
