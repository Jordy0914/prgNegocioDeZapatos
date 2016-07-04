using System;
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
            strSentencia = "Insert into tbFacturaEncabezado(idUsuario,total) values ("+ pEntidadFactura.getIdUsuario()
                + "," + pEntidadFactura.getTotal() +")";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mInsertar

        public Boolean mInsertarFacturaDetalle(clsConexion cone, clsEntidadDetalleFactura pEntidadFacturaD)
        {
            strSentencia = "Insert into tbFacturaDetalle(idFactura,idProducto,cantidad,descuento,subtotal) values (" + pEntidadFacturaD.getIdFactura() + "," + pEntidadFacturaD.getIdProducto()
                + "," + pEntidadFacturaD.getCantidad() + "," + pEntidadFacturaD.getDescuento() + "," + pEntidadFacturaD.getSubTotal() + ")";
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

        }//fin del metodo mEliminarFactura

        public Boolean mModificarFactura(clsConexion cone, clsEntidadFactura pEntidadFactura)
        {
            strSentencia = "Update tbFacturaEncabezado set  where idFactura=" + pEntidadFactura.getIdFactura() + "";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo mModificarFactura

        public SqlDataReader mConsultarIdFactura(clsConexion cone)
        {
            strSentencia = " Select count(idFactura) from tbFacturaEncabezado";
            return cone.mSeleccionar(strSentencia, cone);
        }



        #endregion



    }//fin del metodo  



}

