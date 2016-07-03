using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadDetalleFactura
    {



        #region Atributos

        private int idFactura;
        private int idProducto;
        private int cantidad;
        private Double subtotal;
        private Double descuento;
     


        #endregion


        #region Constructor

        public clsEntidadDetalleFactura()
        {

            this.idFactura = 0;
            this.idProducto = 0;
            this.cantidad = 0;
            this.subtotal = 0.0;
            this.descuento = 0.0;
        

        }

        #endregion

        #region Metodos


        public void setIdFactura(int idFactura)
        {
            this.idFactura = idFactura;

        }


        public int getIdFactura()
        {

            return idFactura;
        }

        public void setIdProducto(int idProducto)
        {
            this.idProducto = idProducto;

        }


        public int getIdProducto()
        {

            return idProducto;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;

        }


        public int getCantidad()
        {

            return cantidad;
        }


        public void setSubTotal(Double subtotal)
        {
            this.subtotal = subtotal;

        }


        public Double getSubTotal()
        {

            return subtotal;
        }



        public void setDescuento(Double descuento)
        {
            this.descuento = descuento;

        }


        public Double getDescuento()
        {

            return descuento;
        }

        #endregion





    }
}
