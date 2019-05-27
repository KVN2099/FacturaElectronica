using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Identificacion
    {
        String Tipo, Numero;

        public String Numero1
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public String Tipo1
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        public Identificacion()
        {
            
        }
    }
}