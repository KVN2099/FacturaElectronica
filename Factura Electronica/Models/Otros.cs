using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Otros
    {
        Otro_Contenido otro_contenido;

        public Otro_Contenido Otro_contenido
        {
            get { return otro_contenido; }
            set { otro_contenido = value; }
        }
        Otro_Texto otro_texto;

        public Otro_Texto Otro_texto
        {
            get { return otro_texto; }
            set { otro_texto = value; }
        }

        public Otros() { }
    }
}