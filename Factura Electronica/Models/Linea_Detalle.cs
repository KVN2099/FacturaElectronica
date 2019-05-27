using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica.Models
{
    public class Linea_Detalle
    {
        int Numero_Linea, cantidad, Monto_Total, Monto_Descuento, Subtotal, Monto_Total_Linea, Precio_Unitario;
        String Unidad_Medida, Unidad_Medida_Comercial, Detalle, Naturaleza_Descuento;
        Codigo codigo;

        public Codigo Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        Impuesto impuesto;

        public Impuesto Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public int Precio_Unitario1
        {
            get { return Precio_Unitario; }
            set { Precio_Unitario = value; }
        }

        public int Monto_Total_Linea1
        {
            get { return Monto_Total_Linea; }
            set { Monto_Total_Linea = value; }
        }

        public int Subtotal1
        {
            get { return Subtotal; }
            set { Subtotal = value; }
        }

        public int Monto_Descuento1
        {
            get { return Monto_Descuento; }
            set { Monto_Descuento = value; }
        }

        public int Monto_Total1
        {
            get { return Monto_Total; }
            set { Monto_Total = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int Numero_Linea1
        {
            get { return Numero_Linea; }
            set { Numero_Linea = value; }
        }
        

        public String Naturaleza_Descuento1
        {
            get { return Naturaleza_Descuento; }
            set { Naturaleza_Descuento = value; }
        }

        public String Detalle1
        {
            get { return Detalle; }
            set { Detalle = value; }
        }

        public String Unidad_Medida_Comercial2
        {
            get { return Unidad_Medida_Comercial; }
            set { Unidad_Medida_Comercial = value; }
        }

        public String Unidad_Medida_Comercial1
        {
            get { return Unidad_Medida_Comercial; }
            set { Unidad_Medida_Comercial = value; }
        }

        public String Unidad_Medida1
        {
            get { return Unidad_Medida; }
            set { Unidad_Medida = value; }
        }

        public Linea_Detalle() { }
    }
}