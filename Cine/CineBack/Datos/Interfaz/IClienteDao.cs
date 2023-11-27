using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        bool Insertar(Cliente cliente);
        bool Actualizar(Cliente cliente);
        bool Borrar(int id);
        DataTable ObtenerClientes();
    }
}
