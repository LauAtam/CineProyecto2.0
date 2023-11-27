using Microsoft.Reporting.WinForms;

namespace CineFront.Presentacion
{
    partial class FrmMasVistas
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
            panelReporte = new Panel();
            reportViewer1 = new ReportViewer();
            panelOpciones = new Panel();
            btnVolver = new Button();
            panelTitulo = new Panel();
            pictureMovie = new PictureBox();
            lblTitulo = new Label();
            pictureProyector = new PictureBox();
            panelContenedor.SuspendLayout();
            panelReporte.SuspendLayout();
            panelOpciones.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProyector).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Transparent;
            panelContenedor.Controls.Add(panelReporte);
            panelContenedor.Controls.Add(panelOpciones);
            panelContenedor.Controls.Add(panelTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1006, 721);
            panelContenedor.TabIndex = 0;
            // 
            // panelReporte
            // 
            panelReporte.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelReporte.Controls.Add(reportViewer1);
            panelReporte.Dock = DockStyle.Fill;
            panelReporte.Location = new Point(0, 100);
            panelReporte.Name = "panelReporte";
            panelReporte.Size = new Size(1006, 561);
            panelReporte.TabIndex = 28;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.IsDocumentMapWidthFixed = true;
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Margin = new Padding(3, 2, 3, 2);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1006, 561);
            reportViewer1.TabIndex = 0;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            // 
            // panelOpciones
            // 
            panelOpciones.BackColor = Color.FromArgb(220, 41, 70);
            panelOpciones.Controls.Add(btnVolver);
            panelOpciones.Dock = DockStyle.Bottom;
            panelOpciones.Location = new Point(0, 661);
            panelOpciones.Name = "panelOpciones";
            panelOpciones.Size = new Size(1006, 60);
            panelOpciones.TabIndex = 27;
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
            btnVolver.Location = new Point(378, 10);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(250, 40);
            btnVolver.TabIndex = 42;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.Transparent;
            panelTitulo.Controls.Add(pictureMovie);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Controls.Add(pictureProyector);
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
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(250, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(506, 28);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "5 PELÍCULAS MÁS VISTAS EN LOS ÚLTIMOS 3 MESES";
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
            // FrmMasVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            ControlBox = false;
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMasVistas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmMasVistas_Load;
            panelContenedor.ResumeLayout(false);
            panelReporte.ResumeLayout(false);
            panelOpciones.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProyector).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panelContenedor;
        private Panel panelTitulo;
        private Label lblTitulo;
        private PictureBox pictureMovie;
        private Panel panelOpciones;
        private Button btnVolver;
        private PictureBox pictureProyector;
        private Panel panelReporte;
    }
}