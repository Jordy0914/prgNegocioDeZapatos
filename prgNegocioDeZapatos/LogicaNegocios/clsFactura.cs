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



        public Boolean mInsertarFacturaEncabezado(clsConexion cone, clsEntidadFacturaEncabezado pEntidadFactura, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Insert into tbFacturaEncabezado(total,creadoPor,fechaCreacion) values (" + pEntidadFactura.getTotal()
                + "," + pEntidadUsuario.IdUsuario + " , getDate())";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mInsertar

        public Boolean mInsertarFacturaDetalle(clsConexion cone, clsEntidadDetalleFactura pEntidadFacturaD)
        {
            strSentencia = "Insert into tbFacturaDetalle(idFactura,idProducto,cantidad,descuento,subtotal) values (" + pEntidadFacturaD.getIdFactura() + "," + pEntidadFacturaD.getIdProducto()
                + "," + pEntidadFacturaD.getCantidad() + "," + pEntidadFacturaD.getDescuento() + "," + pEntidadFacturaD.getSubTotal() + ")";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo mInsertar

        public SqlDataReader mConsultarFacturaDetalle(clsConexion cone, clsEntidadFacturaEncabezado pEntidadFactura)
        {
            strSentencia = " Select * from tbFacturaDetalle where idFactura= " + pEntidadFactura.getIdFactura() + "";
            return cone.mSeleccionar(strSentencia, cone);
        }


        public SqlDataReader mConsultarFacturaEncabezado(clsConexion cone, clsEntidadFacturaEncabezado pEntidadFactura)
        {
            strSentencia = " Select * from tbFacturaEncabezado where idFactura= " + pEntidadFactura.getIdFactura() + "";
            return cone.mSeleccionar(strSentencia, cone);
        }


        public SqlDataReader mConsultarFacturasGenerales(clsConexion cone, clsEntidadFacturaEncabezado pEntidadFactura)
        {
            strSentencia = "Select fD.idFactura,fD.idProducto,fD.cantidad,fD.subtotal,fE.total from tbFacturaEncabezado fE, tbFacturaDetalle fD where fE.idFactura= fD.idFactura and fD.idFactura="+pEntidadFactura.getIdFactura()+"";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean mEliminarFactura(clsConexion cone, clsEntidadDetalleFactura pEntidadFactura)
        {
            strSentencia = "Delete from tbFacturaDetalle  where idFactura="+pEntidadFactura.getIdFactura()+"";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo mEliminarFactura

        public Boolean mModificarFactura(clsConexion cone, clsEntidadFacturaEncabezado pEntidadFactura)
        {
            strSentencia = "Update tbFacturaEncabezado set  where idFactura=" + pEntidadFactura.getIdFactura() + "";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo mModificarFactura

        public SqlDataReader mConsultarIdFactura(clsConexion cone)
        {
            strSentencia = " Select max(idFactura) from tbFacturaEncabezado";
            return cone.mSeleccionar(strSentencia, cone);
        }

        #endregion

    }//fin de la clase 



}

