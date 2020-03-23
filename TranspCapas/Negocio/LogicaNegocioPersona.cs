using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LogicaNegocioPersona
    {
        public int NegociarInsertDatosPersona(int id, string nombre, int edad)
        {
            AccesoMetodosCRUDpersonas acceso = new AccesoMetodosCRUDpersonas();

            return acceso.InsertPersona(id, nombre, edad);
        }
    }
}
