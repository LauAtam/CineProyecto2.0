using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Venta
    {
        public int idVenta { get; set; }
        public DateTime fecha { get; set; }
        public int idPelicula { get; set; }
        public int idFormaPago { get; set; }
        public int idCliente { get; set; }
        public List<DetalleVenta> lDetalles { get; set; }
        public Venta()
        {
            idVenta = 0;
            fecha = new DateTime();
            idPelicula = 0;
            idFormaPago = 0;
            idCliente = 0;
            lDetalles = new List<DetalleVenta>();
        }
        public void AgregarDetalle(DetalleVenta detalle)
        {
            lDetalles.Add(detalle);
        }
        public void QuitarDetalle(int posicion)
        {
            lDetalles.RemoveAt(posicion);
        }
    }
}
