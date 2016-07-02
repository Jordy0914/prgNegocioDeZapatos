﻿using System;
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
        #endregion


        #region Metodos

        public SqlDataReader mConsultarProducto(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {
            strSentencia = "Select * from tbProducto where idProducto ='" + pEntidadInventario.getIdZapato() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarProductoGeneral(clsConexion cone)
        {
            strSentencia = "Select * from tbProducto";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean mInsertar(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {
          strSentencia = "Insert into tbProducto(idProducto,idEmpledo,modelo,nombre,talla,color,costo,precio,marca,categoria,cantidad) Values (" + pEntidadInventario.getIdZapato() + ",'"
                +pEntidadInventario.getIdEmpleado() + ",'"+pEntidadInventario.getModelo()+"','"+pEntidadInventario.getNombre()+"',"
                +pEntidadInventario.getTalla()+",'"+pEntidadInventario.getColor()+"',"+pEntidadInventario.getCosto()+","
                +pEntidadInventario.getPrecio()+",'"+pEntidadInventario.getMarca()+"','"+pEntidadInventario.getCategoria()+"',"
                +pEntidadInventario.getCantidad()+"')";
            return cone.mEjecutar(strSentencia, cone);
        }

        public Boolean mEliminarProducto(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {

            strSentencia = "Delete from tbProducto where idProducto=" + pEntidadInventario.getIdZapato() + "";
            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo

        public Boolean mModificarProducto(clsConexion cone, clsEntidadInventario pEntidadInventario)
        {

         strSentencia = "Update tbProducto set modelo='" + pEntidadInventario.getModelo() + "', talla=" + pEntidadInventario.getTalla() + 
                " , color='"+pEntidadInventario.getColor()+"', costo= "+pEntidadInventario.getCosto()+
                " , precio= "+pEntidadInventario.getPrecio()+" ,marca='"+pEntidadInventario.getMarca()+
                "',categoria='"+pEntidadInventario.getCategoria()+"', cantidad="+pEntidadInventario.getCantidad()+" where idProducto=" + pEntidadInventario.getIdZapato() +"";

            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo modificar 


        #endregion
    }
}
