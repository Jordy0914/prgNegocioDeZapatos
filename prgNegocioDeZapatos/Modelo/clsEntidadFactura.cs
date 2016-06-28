using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class clsEntidadFactura
    {


        #region Atributos

        private int idFactura;
        private int idUsuario;
        private int idProducto; 
        private int cantidad;
        private Double subtotal;
        private Double total;



        #endregion


        #region Constructor

        public clsEntidadFactura()
        {

            this.idFactura = 0;
            this.idUsuario = 0;
            this.idProducto = 0;
            this.cantidad = 0;   
            this.subtotal = 0.0;
            this.total = 0.0;

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


        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;

        }


        public int getIdUsuario()
        {

            return idUsuario;
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


        public void setSubTotal(Double subtoltal)
        {
            this.subtotal = subtoltal;

        }


        public Double getSubToltal()
        {

            return subtotal;
        }


        public void setTotal(Double total)
        {
            this.total = total;

        }


        public Double getToltal()
        {

            return total;
        }


        #endregion


    }
}
