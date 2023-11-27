using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Implementacion
{
    public class VentaDao : IVentaDao
    {
        public int ObtenerProximaVenta()
        {
            return HelperDao.ObtenerHelper().ConsultarEscalar("SP_PROXIMO_ID", "@next");
        }
        public DataTable ConsultarFormaPago()
        {
          return  HelperDao.ObtenerHelper().Consultar("SP_CONSULTAR_FORMASPAGO");
        }

        public bool InsertarVenta(Venta venta)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.ObtenerHelper().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_VENTA";
                comando.Parameters.AddWithValue("@fecha", venta.fecha);
                comando.Parameters.AddWithValue("@id_pelicula", venta.idPelicula);
                comando.Parameters.AddWithValue("@id_forma_pago", venta.idFormaPago);
                comando.Parameters.AddWithValue("@id_cliente", venta.idCliente);

                comando.ExecuteNonQuery();

                int ventaNro = 2;
                SqlCommand cmdDetalle;

                foreach (DetalleVenta dp in venta.lDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLEVENTA", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_venta", ventaNro);
                    cmdDetalle.Parameters.AddWithValue("@precio", Convert.ToDecimal(dp.precio));
                    cmdDetalle.Parameters.AddWithValue("@descuento", dp.descuento);
                    cmdDetalle.Parameters.AddWithValue("@filaButaca", dp.filaButaca);
                    cmdDetalle.Parameters.AddWithValue("@colButaca", dp.colButaca);

                    cmdDetalle.ExecuteNonQuery();
                    ventaNro++;
                }
                t.Commit();
                conexion.Close();
            }
            catch (Exception ex)
            {
                if (t != null)
                    Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace);

                t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }
    }
}
