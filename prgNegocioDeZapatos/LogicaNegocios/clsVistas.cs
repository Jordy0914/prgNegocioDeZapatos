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
        #endregion

        #region Metodos
        public SqlDataReader mConsultarVistasGenerales(clsConexion cone)
        {
            this.strSentencia = "Select V.idVista, V.descripcion from tbVistas V";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarPermisosVista(clsConexion cone, clsEntidadVista pEntidadVista)
        {
            strSentencia = "Select VT.insertar, VT.modificar, VT.eliminar, VT.consultar from tbVistasTemp VT where VT.url ='" + pEntidadVista.Url + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }//fin del metodo mConsultarIdVista
        #endregion
    }
}
