using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineBack.Entidades;
using CineBack.Datos.Interfaz;
using System.Data;

namespace CineBack.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public bool Insertar(Cliente cliente)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@nombre", cliente.nombre),
                new Parametro("@apellido", cliente.apellido),
                new Parametro("@telefono", cliente.telefono),
                new Parametro("@fecha_nac", cliente.fechaNac),
            };
            return HelperDao.ObtenerHelper().Transaccion("SP_INSERTAR_CLIENTE", parametros);
        }
        public bool Actualizar(Cliente cliente)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@id_cliente", cliente.idCliente),
                new Parametro("@nombre", cliente.nombre),
                new Parametro("@apellido", cliente.apellido),
                new Parametro("@telefono", cliente.telefono),
                new Parametro("@fecha_nac", cliente.fechaNac),
            };
            return HelperDao.ObtenerHelper().Transaccion("SP_ACTUALIZAR_CLIENTE", parametros);
        }

        public bool Borrar(int id)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@id_cliente", id)
            };
            return HelperDao.ObtenerHelper().Transaccion("SP_BORRAR_CLIENTE", parametros);
        }

        public DataTable ObtenerClientes()
        {
            return HelperDao.ObtenerHelper().Consultar("SP_CONSULTAR_CLIENTES");
        }
    }
}
