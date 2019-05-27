using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Informacion_Referencia
    {
        String Tipo_Doc, Codigo, Numero, Razon;
        DateTime Fecha_Emision;

        public DateTime Fecha_Emision1
        {
            get { return Fecha_Emision; }
            set { Fecha_Emision = value; }
        }

        public String Razon1
        {
            get { return Razon; }
            set { Razon = value; }
        }

        public String Numero1
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public String Codigo1
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public String Tipo_Doc1
        {
            get { return Tipo_Doc; }
            set { Tipo_Doc = value; }
        }

        public Informacion_Referencia() { }
    }
}