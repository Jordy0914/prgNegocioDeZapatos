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
        private Double total;



        #endregion


        #region Constructor

        public clsEntidadFactura()
        {

            this.idFactura = 0;
            this.idUsuario = 0;
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

        public void setTotal(Double total)
        {
            this.total = total;

        }

        public Double getTotal()
        {

            return total;
        }


        #endregion


    }
}
