using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Codigo
    {
        String Tipo, codigo;

        public String Codigo1
        {
            get { return codigo; }
            set { codigo = value; }
        }

     

        public String Tipo1
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        public Codigo() { }
    }
}