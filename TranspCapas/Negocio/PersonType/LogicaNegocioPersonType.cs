using Modelo.PersonType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.PersonType
{
    public class LogicaNegocioPersonType
    {
        //Insert
        public int NegociarInsertDatosPT(int id, string nombre)
        {
            AccesoMetodosCRUDperson_type acceso = new AccesoMetodosCRUDperson_type();

            return acceso.InsertPersonaType(id, nombre);
        }

        //List
        public static DataTable NegociarListarDatosPT()
        {
            return AccesoMetodosCRUDperson_type.ListarPersonaType();
        }

        //Update
        public int NegociarUpdateDatosPT(int idtipo, string nombretipo)
        {
            AccesoMetodosCRUDperson_type acceso = new AccesoMetodosCRUDperson_type();
            return acceso.ActualizarPersonaType(idtipo, nombretipo);
        }

        //Delete
        public int NegociarDeleteDatosPT(int idtipo)
        {
            AccesoMetodosCRUDperson_type acceso = new AccesoMetodosCRUDperson_type();
            return acceso.DeletePersonaType(idtipo);
        }
    }
}
