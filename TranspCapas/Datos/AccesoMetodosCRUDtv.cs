using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AccesoMetodosCRUDtv
    {
        public int InsertTv(int tv_id, string tv_name)
        {
            SqlCommand _comando = MetodosCRUDtv.CrearComandoProcInsert();
            _comando.Parameters.AddWithValue("@IdTv", tv_id);
            _comando.Parameters.AddWithValue("@NomTv", tv_name);

            return MetodosCRUDtv.EjecutarComandoProcInsert(_comando);
        }
    }
}
