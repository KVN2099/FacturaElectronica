using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Normativa
    {
        DateTime Fecha_Resolucion;
        String Numero_Resolucion;

        public String Numero_Resolucion1
        {
            get { return Numero_Resolucion; }
            set { Numero_Resolucion = value; }
        }

        public DateTime Fecha_Resolucion1
        {
            get { return Fecha_Resolucion; }
            set { Fecha_Resolucion = value; }
        }

        public Normativa() { }
    }
}