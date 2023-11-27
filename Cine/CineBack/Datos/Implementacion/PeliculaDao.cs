using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Implementacion
{
    public class PeliculaDao : IPeliculaDao
    {
        public DataTable TraerPeliculas()
        {
          return HelperDao.ObtenerHelper().Consultar("SP_CONSULTAR_PELICULAS_DETALLES");
        }
        //public DataTable TraerPeliculasDetalles()
        //{
        //    return HelperDao.ObtenerHelper().Consultar("SP_CONSULTAR_PELICULAS_DETALLES");
        //}
        public DataTable TraerPeliculasDesdeHasta(List<Parametro> lstparametros)
        { 
            return HelperDao.ObtenerHelper().Consultar("SP_CONSULTAR_PELICULAS_DESDE_HASTA", lstparametros);
        }
    }
}
