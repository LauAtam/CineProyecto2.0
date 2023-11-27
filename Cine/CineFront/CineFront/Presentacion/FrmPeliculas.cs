using CineBack.Datos.Implementacion;
using CineBack.Entidades;
using CineBack.Servicios.Implementacion;
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
    public partial class FrmPeliculas : Form
    {
        Servicio servicio = new Servicio();
        List<Pelicula> peliculas;
        public FrmPeliculas()
        {
            InitializeComponent();
            borrarFiltros();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            disponerPeliculas();
        }
        private void disponerPeliculas()
        {
            List<ItemPelicula> listaDetalles;
            if (flowPanelPeliculas.Controls.Count > 0)
            {
                flowPanelPeliculas.Controls.Clear();
            }
            foreach (Pelicula pelicula in peliculas)
            {
                ItemPelicula nuevoDetalle = new ItemPelicula()
                {
                    Titulo = pelicula.titulo,
                    Año = pelicula.fechaPublicacion.Year,
                    Genero = pelicula.genero,
                    Audio = pelicula.Audio,
                    Subtitulos = pelicula.Subtitulos,
                    Sinopsis = pelicula.sinopsis,
                    Portada = Image.FromFile("C:\\Users\\Lautaro\\Desktop\\CineProyecto2.0\\Cine\\CineFront\\CineFront\\Recursos\\Peliculas\\Portadas\\" + pelicula.idPelicula + ".jpg")
                };
                flowPanelPeliculas.Controls.Add(nuevoDetalle);
            }
        }
        private void borrarFiltros()
        {
            peliculas = servicio.ConsultarPeliculas();
            dtpDesde.Value = Convert.ToDateTime("1-1-1753");
            dtpHasta.Value = DateTime.Now;
        }
        private void filtrarPeliculas(int desde, int hasta)
        {
            peliculas = servicio.ConsultarPeliculasFiltradas(desde, hasta);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            filtrarPeliculas(Convert.ToInt32(dtpDesde.Value.Year), Convert.ToInt32(dtpHasta.Value.Year));
            disponerPeliculas();
        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {
            borrarFiltros();
            disponerPeliculas();
        }
    }
}