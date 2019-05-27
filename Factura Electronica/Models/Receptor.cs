using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Receptor:Emisor
    {
        string IdentificacionExtranjera;

        public string IdentificacionExtranjera1
        {
            get { return IdentificacionExtranjera; }
            set { IdentificacionExtranjera = value; }
        }
        public Receptor()
        {

        }
    }
}