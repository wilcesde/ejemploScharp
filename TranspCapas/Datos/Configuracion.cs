﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Configuracion
    {
        //static string cadenaConexion = @"Data Source=PALE-HP\SQLEXPRESS; Initial Catalog=ejinstitucion; User ID=user; Password=password";
        static string cadenaConexion = @"Data Source=PALE-HP\SQLEXPRESS; Initial Catalog=ejinstitucion; Trusted_Connection=true";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }    
    }
}
