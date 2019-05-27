using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Impuesto
    {
        Exoneracion exoneracion;

        public Exoneracion Exoneracion
        {
            get { return exoneracion; }
            set { exoneracion = value; }
        }

        int Monto;
        String Codigo, Tarifa;

        public String Tarifa1
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }

        public String Codigo1
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public int Monto1
        {
            get { return Monto; }
            set { Monto = value; }
        }

        public Impuesto() { }
    }
}