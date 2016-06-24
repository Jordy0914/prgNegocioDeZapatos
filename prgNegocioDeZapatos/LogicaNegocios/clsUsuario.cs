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
        #endregion

        #region Metodos
        //Metodo para accesar al sistema, trae codigo y clave de ventana de acceso
        public SqlDataReader mConsultarUsuario(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select idUsuario, login, password from tbUsuario where login='" + pEntidadUsuario.getLogin() + "' and password='" + pEntidadUsuario.getPassword() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarRol(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select idRol from tbUsuariosRoles where idUsuario=" + pEntidadUsuario.getIdUsuario() + "   ";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarMenu(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select distinct M.idMenuPadre, M.descripcion, M.posicion, M.habilitadoMenu, M.url from tbMenu M, tbRolesVistas RV where idRol = '"+pEntidadUsuario.getIdUsuario()+"' order by M.posicion";
            return cone.mSeleccionar(strSentencia, cone);
        }

        #endregion
    }
}
