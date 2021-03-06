﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class clsEntidadFacturaEncabezado
    {


        #region Atributos

        private int idFactura;
        private Double total;
        private int creadoPor;
        private DateTime fechaCreacion;
        private int modificadoPor;
        private DateTime fechaModificacion;


        #endregion


        #region Constructor

        public clsEntidadFacturaEncabezado()
        {

            this.idFactura = 0;
            this.total = 0.0;
            this.creadoPor = 0;
            this.fechaCreacion = DateTime.MaxValue;
            this.modificadoPor = 0;
            this.fechaModificacion = DateTime.MaxValue;
       
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

       

        public void setTotal(Double total)
        {
            this.total = total;
        }

        public Double getTotal()
        {

            return total;
        }

        public void setCreadoPor(int creadoPor)
        {
            this.creadoPor = creadoPor;

        }

        public int getCreadoPor()
        {

            return creadoPor;
        }

        public void setFechaCreacion(DateTime fechaCreacion)
        {
            this.fechaCreacion = fechaCreacion;
        }


        public DateTime getFechaCreacion()
        {

            return fechaCreacion;
        }

        public void setModificadoPor(int modificadoPor)
        {
            this.modificadoPor = modificadoPor;

        }

        public int getModificadoPor()
        {

            return modificadoPor;
        }


        public void setFechaModificacion(DateTime fechaModificacion)
        {
            this.fechaModificacion = fechaModificacion;
        }


        public DateTime getFechaModificacion()
        {

            return fechaModificacion;
        }



        #endregion


    }
}
