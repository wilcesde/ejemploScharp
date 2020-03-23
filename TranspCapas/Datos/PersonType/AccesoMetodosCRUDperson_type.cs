using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PersonType
{
    public class AccesoMetodosCRUDperson_type
    {
        public int InsertPersonaType(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDperson_type.CrearComandoProcAlmacInsert_pt();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre_tipo", nombre);

            return MetodosCRUDperson_type.EjecutarComandoProcAlmacInsert_pt(_comando);
        }

        //Operacion select(listar)
        public static DataTable ListarPersonaType()
        {
            SqlCommand _comando = MetodosCRUDperson_type.CrearComandoSelect_pt();
            _comando.CommandText = "select * from tipo_personas_test";
            return MetodosCRUDperson_type.EjecutarComandoSelect_pt(_comando);
        }

        //Operacion Update
        public int ActualizarPersonaType(int idtipo, string nombretipo)
        {
            SqlCommand _comando = MetodosCRUDperson_type.CrearProcAct_pt();
            _comando.Parameters.AddWithValue("id", idtipo);
            _comando.Parameters.AddWithValue("@nombre_tipo", nombretipo);

            return MetodosCRUDperson_type.EjeProcAct_pt(_comando);
        }

        //Operacion delete
        public int DeletePersonaType(int idtipo)
        {
            SqlCommand _comando = MetodosCRUDperson_type.CrearProcDel_pt();
            _comando.Parameters.AddWithValue("@id", idtipo);

            return MetodosCRUDperson_type.EjecProcDel_pt(_comando);
        }
    }
}
