using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Factura_Electronica
    {
        Emisor emisor;
        List<Linea_Detalle> Detalle_Servicio;

        public List<Linea_Detalle> Detalle_Servicio1
        {
            get { return Detalle_Servicio; }
            set { Detalle_Servicio = value; }
        }

        public Emisor Emisor
        {
            get { return emisor; }
            set { emisor = value; }
        }
        Receptor receptor;

        public Receptor Receptor
        {
            get { return receptor; }
            set { receptor = value; }
        }
        Resumen_Factura resumen_factura;

        public Resumen_Factura Resumen_factura
        {
            get { return resumen_factura; }
            set { resumen_factura = value; }
        }
        Informacion_Referencia informacion_referencia;

        public Informacion_Referencia Informacion_referencia
        {
            get { return informacion_referencia; }
            set { informacion_referencia = value; }
        }
        Normativa normativa;

        public Normativa Normativa
        {
            get { return normativa; }
            set { normativa = value; }
        }
        Otros otros;

        public Otros Otros
        {
            get { return otros; }
            set { otros = value; }
        }

        String Clave, Condicion_Venta;

        public String Condicion_Venta1
        {
            get { return Condicion_Venta; }
            set { Condicion_Venta = value; }
        }

        public String Clave1
        {
            get { return Clave; }
            set { Clave = value; }
        }
        int Consecutivo;

        public int Consecutivo1
        {
            get { return Consecutivo; }
            set { Consecutivo = value; }
        }
        DateTime Fecha_Emision;

        public DateTime Fecha_Emision1
        {
            get { return Fecha_Emision; }
            set { Fecha_Emision = value; }
        }

        public Factura_Electronica() { }
    }
}