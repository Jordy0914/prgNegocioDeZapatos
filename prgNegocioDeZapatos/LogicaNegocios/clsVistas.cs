using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;
using AccesoDatos;


namespace LogicaNegocios
{
    public class clsVistas
    {

        #region Atributos
        //Permite las sentencias del SQL Transac
        private string strSentencia;
        //Permite enviar la ejecución de la sentencia al modelo en la clase conexion

        clsConexion conexion = new clsConexion();
        #endregion


        #region Metodos

        public SqlDataReader mConsultarIdVista(clsConexion cone, clsEntidadVista pEntidadVista)
        {
            strSentencia = "Select * from tbVistas where idVista ='" + pEntidadVista.idVista + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }//fin del metodo mConsultarIdVista


        public SqlDataReader mConsultarIdVistaGeneral(clsConexion cone)
        {
            strSentencia = "Select * from tbVistas";
            return cone.mSeleccionar(strSentencia, cone);
        }//fin del metodo mConsultarIdVistaGeneral


        public Boolean mInsertarVista(clsConexion cone, clsEntidadVista pEntidadVista)
        {
            strSentencia = "Insert into tbVistas(idVista,nombre) values ('" + pEntidadVista.idVista + "','"+pEntidadVista.nombre+"'')";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mInsertarVista

        public Boolean mEliminarVista(clsConexion cone, clsEntidadVista pEntidadVista)
        {
            strSentencia = "Delete from tbVistas where idVista='" + pEntidadVista.idVista + "'";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mEliminarVista


        #endregion

    }
}
