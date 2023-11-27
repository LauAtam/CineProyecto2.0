using CineBack.Datos;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Servicios.Interfaz
{
    public interface IServicio
    {
        //CLIENTE
        bool InsertarCliente(Cliente c);

        bool ActualizarCliente(Cliente c);

        bool BorrarCliente(int id);

        List<Cliente> ObtenerClientes();

        //VENTA 
        bool InsertarVenta(Venta v);

        int Proximo_Id();

        List<FormaPago> ConsulFormPago();

        //PELICULA

        List<Pelicula> ConsultarPeliculas();
        //List<Pelicula> ConsultarPeliculasDetalles();
        List<Pelicula> ConsultarPeliculasFiltradas(List<Parametro> lstParametros);

    }
}
