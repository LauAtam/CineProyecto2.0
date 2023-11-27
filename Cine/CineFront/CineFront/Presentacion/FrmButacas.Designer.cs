using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace CineFront.Presentacion
{
    partial class FrmButacas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox12 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label2 = new Label();
            label3 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox9 = new PictureBox();
            btnSeleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen3Butacas;
            pictureBox1.Location = new Point(124, 183);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Imagen3Butacas;
            pictureBox2.Location = new Point(197, 272);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Imagen3Butacas;
            pictureBox5.Location = new Point(124, 272);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox21
            // 
            pictureBox21.Image = Properties.Resources.Imagen3Butacas;
            pictureBox21.Location = new Point(265, 183);
            pictureBox21.Margin = new Padding(3, 4, 3, 4);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(45, 44);
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox21.TabIndex = 22;
            pictureBox21.TabStop = false;
            pictureBox21.Click += pictureBox21_Click;
            // 
            // pictureBox22
            // 
            pictureBox22.Image = Properties.Resources.Imagen3Butacas;
            pictureBox22.Location = new Point(197, 183);
            pictureBox22.Margin = new Padding(3, 4, 3, 4);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(45, 44);
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox22.TabIndex = 23;
            pictureBox22.TabStop = false;
            pictureBox22.Click += pictureBox22_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Imagen3Butacas;
            pictureBox3.Location = new Point(265, 349);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Imagen3Butacas;
            pictureBox4.Location = new Point(197, 349);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Imagen3Butacas;
            pictureBox6.Location = new Point(448, 349);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Imagen3Butacas;
            pictureBox7.Location = new Point(515, 349);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Imagen3Butacas;
            pictureBox8.Location = new Point(265, 272);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 44);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 28;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox23
            // 
            pictureBox23.Image = Properties.Resources.Imagen3Butacas;
            pictureBox23.Location = new Point(515, 183);
            pictureBox23.Margin = new Padding(3, 4, 3, 4);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(45, 44);
            pictureBox23.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox23.TabIndex = 27;
            pictureBox23.TabStop = false;
            pictureBox23.Click += pictureBox23_Click;
            // 
            // pictureBox24
            // 
            pictureBox24.Image = Properties.Resources.Imagen3Butacas;
            pictureBox24.Location = new Point(375, 349);
            pictureBox24.Margin = new Padding(3, 4, 3, 4);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(45, 44);
            pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox24.TabIndex = 32;
            pictureBox24.TabStop = false;
            pictureBox24.Click += pictureBox24_Click;
            // 
            // pictureBox25
            // 
            pictureBox25.Image = Properties.Resources.Imagen3Butacas;
            pictureBox25.Location = new Point(376, 183);
            pictureBox25.Margin = new Padding(3, 4, 3, 4);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(45, 44);
            pictureBox25.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox25.TabIndex = 31;
            pictureBox25.TabStop = false;
            pictureBox25.Click += pictureBox25_Click;
            // 
            // pictureBox26
            // 
            pictureBox26.Image = Properties.Resources.Imagen3Butacas;
            pictureBox26.Location = new Point(448, 183);
            pictureBox26.Margin = new Padding(3, 4, 3, 4);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(45, 44);
            pictureBox26.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox26.TabIndex = 30;
            pictureBox26.TabStop = false;
            pictureBox26.Click += pictureBox26_Click;
            // 
            // pictureBox27
            // 
            pictureBox27.Image = Properties.Resources.Imagen3Butacas;
            pictureBox27.Location = new Point(448, 272);
            pictureBox27.Margin = new Padding(3, 4, 3, 4);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(45, 44);
            pictureBox27.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox27.TabIndex = 35;
            pictureBox27.TabStop = false;
            pictureBox27.Click += pictureBox27_Click;
            // 
            // pictureBox28
            // 
            pictureBox28.Image = Properties.Resources.Imagen3Butacas;
            pictureBox28.Location = new Point(517, 272);
            pictureBox28.Margin = new Padding(3, 4, 3, 4);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(45, 44);
            pictureBox28.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox28.TabIndex = 34;
            pictureBox28.TabStop = false;
            pictureBox28.Click += pictureBox28_Click;
            // 
            // pictureBox29
            // 
            pictureBox29.Image = Properties.Resources.Imagen3Butacas;
            pictureBox29.Location = new Point(375, 272);
            pictureBox29.Margin = new Padding(3, 4, 3, 4);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(45, 44);
            pictureBox29.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox29.TabIndex = 33;
            pictureBox29.TabStop = false;
            pictureBox29.Click += pictureBox29_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.Imagen3Butacas;
            pictureBox12.Location = new Point(124, 349);
            pictureBox12.Margin = new Padding(3, 4, 3, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(45, 44);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 36;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(54, 157);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 37;
            label1.Text = "Fila";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(38, 414);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 41;
            label5.Text = "Columna";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(142, 414);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 42;
            label6.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(535, 414);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 43;
            label7.Text = "6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(466, 414);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 44;
            label8.Text = "5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(393, 414);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 45;
            label9.Text = "4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(283, 414);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 46;
            label10.Text = "3";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(215, 414);
            label11.Name = "label11";
            label11.Size = new Size(18, 20);
            label11.TabIndex = 47;
            label11.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 203);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 48;
            label2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(69, 292);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 49;
            label3.Text = "2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(69, 369);
            label12.Name = "label12";
            label12.Size = new Size(18, 20);
            label12.TabIndex = 50;
            label12.Text = "3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(28, 9);
            label13.Name = "label13";
            label13.Size = new Size(145, 28);
            label13.TabIndex = 51;
            label13.Text = "Elegir butacas";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Imagen5Butacas;
            pictureBox9.Location = new Point(179, -18);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(329, 150);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 52;
            pictureBox9.TabStop = false;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeleccionar.Location = new Point(283, 499);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(128, 36);
            btnSeleccionar.TabIndex = 53;
            btnSeleccionar.Text = "Continuar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FrmButacas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(686, 576);
            Controls.Add(btnSeleccionar);
            Controls.Add(pictureBox9);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmButacas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox12;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label2;
        private Label label3;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox9;
        private Button btnSeleccionar;
    }
}