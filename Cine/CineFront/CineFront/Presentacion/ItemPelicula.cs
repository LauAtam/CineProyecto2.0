using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class ItemPelicula : UserControl
    {
        public ItemPelicula()
        {
            InitializeComponent();
        }
        #region Propiedades
        private string _titulo;
        private int _año;
        private string _genero;
        private string _audio;
        private string _subtitulos;
        private string _sinopsis;
        private Image _portada;

        private void ItemPelicula_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonShadow;
        }

        private void ItemPelicula_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        [Category("Custom Props")]
        public Image Portada
        {
            get { return _portada; }
            set { _portada = value; picturePortada.Image = value; }
        }

        [Category("Custom Props")]
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; lblTitulo.Text = "Título: " + value; }
        }

        [Category("Custom Props")]
        public int Año
        {
            get { return _año; }
            set { _año = value; lblAño.Text = "Año: " + Convert.ToString(value); }
        }

        [Category("Custom Props")]
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; lblGenero.Text = "Género: " + value; }
        }

        [Category("Custom Props")]
        public string Audio
        {
            get { return _audio; }
            set { _audio = value; lblAudio.Text = "Audio: " + value; }
        }

        [Category("Custom Props")]
        public string Subtitulos
        {
            get { return _subtitulos; }
            set { _subtitulos = value; lblSubtitulos.Text = "Subtitulos: " + value; }
        }

        [Category("Custom Props")]
        public string Sinopsis
        {
            get { return _sinopsis; }
            set { _sinopsis = value; lblSinopsis.Text = value; }
        }
        #endregion

    }
}
