using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MetodosCRUDpersonas
    {
        //Crear tipo comando forma insertar
        public static SqlCommand CrearComandoProcAlmacInsert()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("registrarPersonas", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Crear ejecucion del tipo comando
        public static int EjecutarComandoProcAlmacInsert(SqlCommand comando)
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

    }
}
