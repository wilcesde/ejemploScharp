using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Configuracion
    {
        static string cadenaConexion = @"Data Source=SQL-AC\DOCENTE2;Initial Catalog=vehiculosWCG;User ID=DOCENTE2; Password=98jhvd2017centr0";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
