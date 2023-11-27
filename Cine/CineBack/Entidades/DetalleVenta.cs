using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class DetalleVenta
    {
        public int idDetalle { get; set; }
        public int idVenta { get; set; }
        public double precio { get; set; }
        public double descuento { get; set; }
        public int filaButaca { get; set; }
        public int colButaca { get; set; }
        public DetalleVenta()
        {
            idDetalle = 0;
            idVenta = 0;
            precio = 2500;
            descuento = 0;
            filaButaca = 0;
            colButaca = 0;
        }
        public DetalleVenta(double precio, double descuento, int filaButaca, int colButaca)
        {
            this.precio = precio;
            this.descuento = descuento;
            this.filaButaca = filaButaca;
            this.colButaca = colButaca;
        }
        public double CalcularPrecio(int descuento)
        {
            return precio - (descuento * precio / 100);
        }
    }
}
