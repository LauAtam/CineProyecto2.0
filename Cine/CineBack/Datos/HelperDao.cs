using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos
{
    public class HelperDao
    {
        private static HelperDao helper;
        private SqlConnection conexion;
        private HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.cadenaConexionMarco);
        }
        public static HelperDao ObtenerHelper()
        {
            if (helper == null)
            {
                helper = new HelperDao();
            }
            return helper;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }
        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            int salida;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = nombreParamOut;
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;

                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();

                salida = (int)parametro.Value;
                conexion.Close();
            }
            catch
            {
                salida = -1;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return salida;
        }
        public DataTable Consultar(string nombreSP){

            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
            //DataTable tabla = new DataTable();
            //try
            //{
            //conexion.Open();
            //SqlCommand comando = new SqlCommand();
            //comando.Connection = conexion;
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.CommandText = nombreSP;
            //tabla.Load(comando.ExecuteReader());
            //}
            //catch
            //{
            //    tabla.Clear();
            //}
            //finally
            //{
            //    if (conexion != null && conexion.State == ConnectionState.Open)
            //        conexion.Close();
            //}
            //return tabla;

        }
        public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
                comando.Parameters.Clear();
                foreach (Parametro p in lstParametros)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                tabla.Load(comando.ExecuteReader());
            }
            catch
            {
                tabla.Clear() ;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return tabla;
        }
        public bool Transaccion(string nombreSP, List<Parametro> lParametros)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
                comando.Parameters.Clear();
                foreach (Parametro p in lParametros)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch
            {
                if (t != null) 
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
