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

        public SqlDataReader mConsultarMenuPrincipal(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select distinct M.idMenu, M.descripcion, M.posicion, M.habilitadoMenu from tbMenu M, tbRolesVistas RV , tbUsuariosRoles UR where RV.idRol = UR.idRol and UR.idUsuario = '"+pEntidadUsuario.getIdUsuario()+"' and M.idMenuPadre = (Select idMenu from tbMenu where descripcion = 'Principal') order by M.posicion";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarSubmenus(clsConexion cone,clsEntidadUsuario pEntidadUsuario,int menuPadre)
        {
            strSentencia = "Select distinct M.idMenu, M.descripcion, M.posicion, M.habilitadoMenu from tbMenu M, tbRolesVistas RV , tbUsuariosRoles UR where RV.idRol = UR.idRol and UR.idUsuario = '" + pEntidadUsuario.getIdUsuario() + "' and M.idMenuPadre = " + menuPadre+"  order by M.posicion";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public void mInsertarMenuTemporal(clsConexion cone, clsEntidadMenu pEntidadMenu)
        {
            strSentencia = "Insert into tbMenuTemp (idMenu, idMenuPadre, descripcion, posicion, habilitadoMenu, url) "
                + "values("+pEntidadMenu.getIdMenu()+" , "+pEntidadMenu.getIdMenuPadre()+" , '"+pEntidadMenu.getDescripcion()+"' , "+pEntidadMenu.getPosicion()+" , "+pEntidadMenu.getHabilitadoMenu()+" , '"+pEntidadMenu.getUrl()+"'       )";

            cone.mEjecutar(strSentencia, cone);
        }

        public SqlDataReader mConsultarUsuarioNombre(clsConexion cone)
        {
            strSentencia = "Select * from tbUsuario";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarUsuarioGeneral(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select * from tbUsuario where idUsuario= '"+pEntidadUsuario.getIdUsuario()+"'";
            return cone.mSeleccionar(strSentencia, cone);
        }




        #endregion


    }
}
