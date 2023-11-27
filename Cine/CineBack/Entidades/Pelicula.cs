using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Pelicula
    {
        public int idPelicula { get; set; }
        public string titulo { get; set; }
        public string sinopsis { get; set; }
        public string genero { get; set; }
        public object duracion { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public string Audio { get; set; }
        public string Subtitulos { get; set; }
        public Pelicula()
        {
            idPelicula = 0;
            titulo = string.Empty;
            sinopsis = string.Empty;
            genero = string.Empty;
            duracion = null;
            fechaPublicacion = DateTime.MinValue;
            Audio = string.Empty;
            Subtitulos = string.Empty;
        }
        public Pelicula(int id_pelicula, string titulo, object duracion, DateTime fechaPublicacion, string genero, string sinopsis, string idAudio, string idSubtitulos)
        {
            this.idPelicula = idPelicula;
            this.titulo = titulo;
            this.duracion = duracion;
            this.fechaPublicacion = fechaPublicacion;
            this.genero = genero;
            this.sinopsis = sinopsis;
            this.Audio = idAudio;
            this.Subtitulos = idSubtitulos;
        }
    }
}
