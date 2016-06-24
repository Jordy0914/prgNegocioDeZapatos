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
    public class clsUsuario
    {
        #region Atributos
        //Permite las sentencias del SQL Transac
        private string strSentencia;
        //Permite enviar la ejecución de la sentencia al modelo en la clase conexion
        
        clsConexion conexion = new clsConexion();
        #endregion

        #region Metodos
        //Metodo para accesar al sistema, trae codigo y clave de ventana de acceso
        public SqlDataReader mConsultarUsuario(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select * from tbUsuario where usuario='" + pEntidadUsuario.getLogin() + "' and password='" + pEntidadUsuario.getPassword() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }
        

        public SqlDataReader mConsultarCodigo (clsConexion cone, Entidades.clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select * from tbUsuario where usuario ='" + pEntidadUsuario.getLogin() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarCodigo2(clsConexion cone)
        {
            strSentencia = "Select * from tbUsuario";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean mInsertar(clsConexion cone, clsEntidadUsuario pEntidadUsuaio)
        {
            strSentencia = "Insert into tbUsuario() Values ('" + pEntidadUsuaio.getLogin() + "','"
                + pEntidadUsuaio.getPassword() + "')";
            return cone.mEjecutar(strSentencia, cone);
        }

        #endregion
    }
}
