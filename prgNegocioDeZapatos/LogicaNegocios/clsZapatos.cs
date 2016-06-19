using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

using System.Data.SqlClient;
using Entidades;
using AccesoDatos;



namespace LogicaNegocios
{
    public class clsZapatos
    {

        #region Atributos
        //Permite las sentencias del SQL Transac
        private string strSentencia;
        //Permite enviar la ejecución de la sentencia al modelo en la clase conexion

        clsConexion conexion = new clsConexion();
        #endregion


        #region Metodos

        public SqlDataReader mConsultarIdInventario(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {
            strSentencia = "Select * from tbInventario where idZapato ='" + pEntidadInventario.getIdZapato() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarIdInventarioGeneral(clsConexion cone)
        {
            strSentencia = "Select * from tbInventario";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean mInsertar(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {
          strSentencia = "Insert into tbInventario(idZapatos,idEmpledo,modelo,nombre,talla,color,costo,precio,marca,categoria,cantidad) Values (" + pEntidadInventario.getIdZapato() + ",'"
                +pEntidadInventario.getIdEmpleado() + ",'"+pEntidadInventario.getModelo()+"','"+pEntidadInventario.getNombre()+"',"
                +pEntidadInventario.getTalla()+",'"+pEntidadInventario.getColor()+"',"+pEntidadInventario.getCosto()+","
                +pEntidadInventario.getPrecio()+",'"+pEntidadInventario.getMarca()+"','"+pEntidadInventario.getCategoria()+"',"
                +pEntidadInventario.getCantidad()+"')";
            return cone.mEjecutar(strSentencia, cone);
        }



        public Boolean mEliminarInventario(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {

            strSentencia = "Delete from tbInventario where idZapato=" + pEntidadInventario.getIdZapato() + "";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo

        public Boolean mModificarInventario(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {

         strSentencia = "Update tbInventario set modelo='" + pEntidadInventario.getModelo() + "', talla=" + pEntidadInventario.getTalla() + 
                " , color='"+pEntidadInventario.getColor()+"', costo= "+pEntidadInventario.getCosto()+
                " , precio= "+pEntidadInventario.getPrecio()+" ,marca='"+pEntidadInventario.getMarca()+
                "',categoria='"+pEntidadInventario.getCategoria()+"', cantidad="+pEntidadInventario.getCantidad()+" where idZpato=" + pEntidadInventario.getIdZapato() +"";

            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo modificar 


        #endregion
    }
}
