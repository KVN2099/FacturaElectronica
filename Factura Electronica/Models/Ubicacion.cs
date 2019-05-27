using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Ubicacion
    {
        String Canton, Distrito, Barrio, Otras_Senas, Provincia;

        public String Provincia1
        {
            get { return Provincia; }
            set { Provincia = value; }
        }

        public String Otras_Senas1
        {
            get { return Otras_Senas; }
            set { Otras_Senas = value; }
        }

        public String Barrio1
        {
            get { return Barrio; }
            set { Barrio = value; }
        }

        public String Distrito1
        {
            get { return Distrito; }
            set { Distrito = value; }
        }

        public String Canton1
        {
            get { return Canton; }
            set { Canton = value; }
        }

        Ubicacion(String _Provincia, String _Canton, String _Distrito, String _Barrio, String _Otras_Senas)
        {
            Provincia = _Provincia;
            Canton = _Canton;
            Distrito = _Distrito;
            Barrio = _Barrio;
            Otras_Senas = _Otras_Senas;
        }
    }
}