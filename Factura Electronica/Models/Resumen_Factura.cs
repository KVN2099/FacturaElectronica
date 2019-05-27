using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Resumen_Factura
    {
        int Total_Serv_Gravados, Total_Serv_Exentos, Total_Mercancias_Gravadas, Total_Mercancias_Exentas, Total_Gravado, Total_Exento, Total_Venta, Total_Descuentos, Total_Venta_Neta, Total_Impuesto, Total_Comprobante;
        String Codigo_Moneda, Tipo_Cambio;

        public String Tipo_Cambio1
        {
            get { return Tipo_Cambio; }
            set { Tipo_Cambio = value; }
        }

        public String Codigo_Moneda1
        {
            get { return Codigo_Moneda; }
            set { Codigo_Moneda = value; }
        }

        public int Total_Comprobante1
        {
            get { return Total_Comprobante; }
            set { Total_Comprobante = value; }
        }

        public int Total_Impuesto1
        {
            get { return Total_Impuesto; }
            set { Total_Impuesto = value; }
        }

        public int Total_Venta_Neta1
        {
            get { return Total_Venta_Neta; }
            set { Total_Venta_Neta = value; }
        }

        public int Total_Descuentos1
        {
            get { return Total_Descuentos; }
            set { Total_Descuentos = value; }
        }

        public int Total_Venta1
        {
            get { return Total_Venta; }
            set { Total_Venta = value; }
        }

        public int Total_Exento1
        {
            get { return Total_Exento; }
            set { Total_Exento = value; }
        }

        public int Total_Gravado1
        {
            get { return Total_Gravado; }
            set { Total_Gravado = value; }
        }

        public int Total_Mercancias_Exentas1
        {
            get { return Total_Mercancias_Exentas; }
            set { Total_Mercancias_Exentas = value; }
        }

        public int Total_Mercancias_Gravadas1
        {
            get { return Total_Mercancias_Gravadas; }
            set { Total_Mercancias_Gravadas = value; }
        }

        public int Total_Serv_Exentos1
        {
            get { return Total_Serv_Exentos; }
            set { Total_Serv_Exentos = value; }
        }

        public int Total_Serv_Gravados1
        {
            get { return Total_Serv_Gravados; }
            set { Total_Serv_Gravados = value; }
        }

        public Resumen_Factura() { }
    }
}