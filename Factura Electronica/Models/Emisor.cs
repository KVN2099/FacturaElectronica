using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Emisor
    {
        Ubicacion ubicacion;

        public Ubicacion Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        Identificacion identificacion;

        public Identificacion Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        Telefono telefono;

        public Telefono Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        Fax fax;

        public Fax Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        String nombre, Correo;

        public String Correo1
        {
            get { return Correo; }
            set { Correo = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Emisor() {
        
        }
    }
}