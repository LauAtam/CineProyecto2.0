using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNac { get; set; }
        public string nombreCompleto { get; set; }

        public Cliente()
        {
            idCliente = 0;
            nombre = "";
            apellido = "";
            telefono = "";
            fechaNac = DateTime.MinValue;
            nombreCompleto = "";
        }
        public Cliente(string nombre,string apellido,string telefono,DateTime fecha_nac)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.fechaNac = fecha_nac;
        }
    }
}
