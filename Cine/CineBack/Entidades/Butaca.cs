using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Butaca
    {
        public int fila { get; set; }
        public int columna { get; set; }
        public string estado { get; set; }
        public Butaca()
        {
            fila = 0;
            columna = 0;
            estado = string.Empty;
        }
        public Butaca(int fila, int columna, string estado)
        {
            this.fila = fila;
            this.columna = columna;
            this.estado = estado;
        }
    }
}
