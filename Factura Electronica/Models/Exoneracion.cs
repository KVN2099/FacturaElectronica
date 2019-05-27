using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Exoneracion
    {
        int Monto_Impuesto, porcentaje_Compra;
        String Tipo_Documento, Numero_Documento, Nombre_Institucion;
        DateTime Fecha_Emision;

        public DateTime Fecha_Emision1
        {
            get { return Fecha_Emision; }
            set { Fecha_Emision = value; }
        }

        public String Nombre_Institucion1
        {
            get { return Nombre_Institucion; }
            set { Nombre_Institucion = value; }
        }

        public String Numero_Documento1
        {
            get { return Numero_Documento; }
            set { Numero_Documento = value; }
        }

        public String Tipo_Documento1
        {
            get { return Tipo_Documento; }
            set { Tipo_Documento = value; }
        }

        public int Porcentaje_Compra
        {
            get { return porcentaje_Compra; }
            set { porcentaje_Compra = value; }
        }

        public int Monto_Impuesto1
        {
            get { return Monto_Impuesto; }
            set { Monto_Impuesto = value; }
        }

        public Exoneracion() { }
    }
}