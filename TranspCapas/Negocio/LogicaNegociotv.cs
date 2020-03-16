using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LogicaNegociotv
    {
        public int NegociarInsertTv(int tv_id, string tv_name)
        {
            AccesoMetodosCRUDtv acceso = new AccesoMetodosCRUDtv();

            return acceso.InsertTv(tv_id, tv_name);
        }
    }
}
