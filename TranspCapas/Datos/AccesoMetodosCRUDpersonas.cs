using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AccesoMetodosCRUDpersonas
    {
        public int InsertPersona(int id, string nombre, int edad)
        {
            SqlCommand _comando = MetodosCRUDpersonas.CrearComandoProcAlmacInsert();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@edad", edad);

            return MetodosCRUDpersonas.EjecutarComandoProcAlmacInsert(_comando);
        }
    }
}
