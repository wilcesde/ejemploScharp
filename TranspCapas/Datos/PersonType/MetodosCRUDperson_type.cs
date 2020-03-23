using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PersonType
{
    public class MetodosCRUDperson_type
    {
        //Crear tipo comando forma insertar
        public static SqlCommand CrearComandoProcAlmacInsert_pt()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("regTipoPersonasTest", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Crear ejecucion del tipo comando procedure
        public static int EjecutarComandoProcAlmacInsert_pt(SqlCommand comando)
        {
            try
            {
                //instrucciones de aca
                comando.Connection.Open();

                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                //finalice con lo que se defina aqui
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //Crear instrucciones(comandos) SQL select
        public static SqlCommand CrearComandoSelect_pt()
        {
            //Usar la conexion
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //Permitir crear instrucciones select
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;
        }

        //Crear ejecucion del tipo comando select
        public static DataTable EjecutarComandoSelect_pt(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();

            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;
        }

        //crear comando para actualizar
        public static SqlCommand CrearProcAct_pt()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("ActTipoPersonasTest", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        //crear comando para ejecutar el Update
        public static int EjeProcAct_pt(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //crear comando para delete
        public static SqlCommand CrearProcDel_pt()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("DelTipoPersonasTest", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }
        //crear comando para ejecutar el delete
        public static int EjecProcDel_pt(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
