using CineBack.Datos;
using CineBack.Datos.Implementacion;
using CineBack.Entidades;
using CineBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        ClienteDao clienteDao = new ClienteDao();
        VentaDao ventaDao = new VentaDao();
        PeliculaDao peliculaDao = new PeliculaDao();
        //CLIENTE
        public bool InsertarCliente(Cliente c)
        {
            return clienteDao.Insertar(c);
        }
        public bool ActualizarCliente(Cliente c)
        {
            return clienteDao.Actualizar(c);
        }
        public bool BorrarCliente(int id)
        {
            return clienteDao.Borrar(id);
        }
        public List<Cliente> ObtenerClientes()
        {
            DataTable tabla=  clienteDao.ObtenerClientes();
            List<Cliente> clientes = new List<Cliente> ();
            foreach (DataRow row in tabla.Rows)
            {
                Cliente cliente = new Cliente()
                {
                    idCliente = Convert.ToInt32(row["ID"]),
                    nombre = Convert.ToString(row["Nombre"]),
                    apellido = Convert.ToString(row["Apellido"]),
                    fechaNac = Convert.ToDateTime(row["Nacimiento"]),
                    telefono = Convert.ToString(row["Telefono"])
                };
                clientes.Add(cliente);
            }
            return clientes;
        }

        //VENTA
        public bool InsertarVenta(Venta v)
        {
            return ventaDao.InsertarVenta(v);
        }

        public int Proximo_Id()
        {
            return ventaDao.ObtenerProximaVenta();
        }

        public List<FormaPago> ConsulFormPago()
        {
            DataTable tabla = ventaDao.ConsultarFormaPago();
            List<FormaPago> lista = new List<FormaPago>();
            foreach (DataRow row in tabla.Rows)
            {
                FormaPago miObjeto = new FormaPago();
                miObjeto.id_forma_pago = Convert.ToInt32(row["id_forma_pago"]);
                miObjeto.forma = Convert.ToString(row["forma_pago"]);
                // Otros campos según tu estructura de datos


                lista.Add(miObjeto);
            }
            return lista;


        }

        public List<Pelicula> ConsultarPeliculas()
        {
            DataTable tabla = peliculaDao.TraerPeliculas();
            List<Pelicula> lista = new List<Pelicula>();
            foreach (DataRow row in tabla.Rows)
            {
                Pelicula miObjeto = new Pelicula();
                miObjeto.idPelicula = Convert.ToInt32(row["id_pelicula"]);
                miObjeto.titulo = Convert.ToString(row["titulo"]);
                miObjeto.fechaPublicacion = Convert.ToDateTime(row["fecha_publicacion"]);
                miObjeto.genero = Convert.ToString(row["genero"]);
                miObjeto.Audio = Convert.ToString(row["audio"]);
                miObjeto.Subtitulos = Convert.ToString(row["subtitulos"]);
                miObjeto.sinopsis = Convert.ToString(row["sinopsis"]);
                //miObjeto.idSubtitulos = Convert.ToInt32(row["subtitulos"]);

                lista.Add(miObjeto);
            }
            return lista;
                 
        }

        public List<Pelicula> ConsultarPeliculasFiltradas(int desde, int hasta)
        {
            DataTable tabla = peliculaDao.TraerPeliculasDesdeHasta(desde, hasta);
            List<Pelicula> peliculas = new List<Pelicula>();
            foreach (DataRow row in tabla.Rows)
            {
                Pelicula nuevaPelicula = new Pelicula();

                nuevaPelicula.idPelicula = Convert.ToInt32(row["id_pelicula"]);
                nuevaPelicula.titulo = Convert.ToString(row["titulo"]);
                nuevaPelicula.fechaPublicacion = Convert.ToDateTime(row["fecha_publicacion"]);
                nuevaPelicula.genero = Convert.ToString(row["genero"]);
                nuevaPelicula.Audio = Convert.ToString(row["audio"]);
                nuevaPelicula.Subtitulos = Convert.ToString(row["subtitulos"]);
                nuevaPelicula.sinopsis = Convert.ToString(row["sinopsis"]);

                peliculas.Add(nuevaPelicula);
            }
            return peliculas;
        }
    }
}
