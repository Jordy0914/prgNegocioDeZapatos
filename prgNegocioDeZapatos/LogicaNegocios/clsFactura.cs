﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data.SqlClient;

namespace LogicaNegocios
{
    public class clsFactura
    {
        #region Atributos

        private string strSentencia;

        #endregion

        #region Metodos



        public Boolean mInsertarFacturaEncabezado(clsConexion cone, clsEntidadFactura pEntidadFactura)
        {
            strSentencia = "Insert into tbFacturaEncabezado(idFactura,idUsuario,total) values (" + pEntidadFactura.getIdFactura() + "," + pEntidadFactura.getIdUsuario()
                + "," + pEntidadFactura.getTotal() +")";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mInsertar

        public Boolean mInsertarFacturaDetalle(clsConexion cone, clsEntidadFactura pEntidadFactura)
        {
            strSentencia = "Insert into tbFacturaDetalle(idFactura,idProducto,cantidad,subtotal) values (" + pEntidadFactura.getIdFactura() + "," + pEntidadFactura.getIdProducto()
                + "," + pEntidadFactura.getCantidad() + "," + pEntidadFactura.getSubTotal() + ")";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo mInsertar

        public SqlDataReader mConsultarFacturaDetalle(clsConexion cone, clsEntidadFactura pEntidadFactura)
        {
            strSentencia = " Select * from tbFacturaDetalle where idFactura= " + pEntidadFactura.getIdFactura() + "";
            return cone.mSeleccionar(strSentencia, cone);
        }


        public SqlDataReader mConsultarFacturaEncabezado(clsConexion cone, clsEntidadFactura pEntidadFactura)
        {
            strSentencia = " Select * from tbFacturaEncabezado where idFactura= " + pEntidadFactura.getIdFactura() + "";
            return cone.mSeleccionar(strSentencia, cone);
        }

        // select fE.idFactura,fD.idProducto,fE.idUsuario,fD.cantidad,fD.subtotal,fE.total from tbFacturaEncabezado fE,tbFacturaDetalle fD where fD.idFactura=fE.idFactura;

        public Boolean mEliminarFactura(clsConexion cone, clsEntidadFactura pEntidadFactura)
        {
            strSentencia = "Delete from tbFacturaEncabezado where idFactura=" + pEntidadFactura.getIdFactura() + "";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo mEliminarVista

        #endregion



    }//fin del metodo  



}

