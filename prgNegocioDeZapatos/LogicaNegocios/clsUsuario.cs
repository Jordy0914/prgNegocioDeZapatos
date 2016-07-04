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
            strSentencia = "Select login, password from tbUsuario where login='" + pEntidadUsuario.getLogin()+ "' and password='" + pEntidadUsuario.getPassword() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarUsuario2(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select * from tbUsuario where idUsuario='" + pEntidadUsuario.getIdUsuario() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }


        public SqlDataReader mConsultarVistasRol(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select distinct V.idVista, V.idPadre, V.descripcion, V.posicion, V.habilitadoMenu, V.url, RV.insertar, RV.modificar, RV.eliminar, RV.consultar " +
             "from tbVistas V, tbRolesVistas RV, tbUsuariosRoles UR " +
             "where UR.idRol = RV.idRol " +
             "and RV.idVista = V.idVista " +
             "and UR.idUsuario =" + pEntidadUsuario.IdUsuario +"";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarVistasDirectas(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select distinct V.idVista, V.idPadre, V.descripcion, V.posicion, V.habilitadoMenu, V.url, UV.insertar, UV.modificar, UV.eliminar, UV.consultar from tbVistas V, tbUsuarioVistas UV where UV.idVista = V.idVista and UV.idUsuario = " + pEntidadUsuario.IdUsuario +" and V.idVista not in(select idVista from tbVistasTemp)";
            return cone.mSeleccionar(strSentencia, cone);
        }
      
        public SqlDataReader mCrearMenuPrincipal (clsConexion cone)
        {
            strSentencia = "Select distinct VT.idVista, VT.idPadre, VT.descripcion, VT.posicion, VT.habilitadoMenu, VT.url from tbVistasTemp VT where VT.idPadre = (Select idVista from tbVistas where descripcion = 'Principal') order by VT.posicion";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mCrearMenusSecundarios (clsConexion cone, int menuPadre)
        {
            strSentencia = "Select distinct VT.idVista, VT.idPadre, VT.descripcion, VT.posicion, VT.habilitadoMenu, VT.url from tbVistasTemp VT where VT.idPadre = " + menuPadre+" order by VT.posicion";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public void mInsertarVistasTemp(clsConexion cone, clsEntidadVista pEntidadVista)
        {
            strSentencia = "Insert into tbVistasTemp(idVista, idPadre, descripcion, posicion, habilitadoMenu, url, insertar, modificar, eliminar, consultar) "
                + "values(" + pEntidadVista.IdVista + " , " + pEntidadVista.IdPadre + " , '" + pEntidadVista.Descripcion + "' , " + pEntidadVista.Posicion + " , " + pEntidadVista.HabilitadoMenu + " , '" + pEntidadVista.Url + "' , "+pEntidadVista.Insertar+" , "+pEntidadVista.Modificar+" , "+pEntidadVista.Eliminar+" , "+pEntidadVista.Consultar+")";
            cone.mEjecutar(strSentencia, cone);
        }

        public void mEliminarVistasTemp(clsConexion cone)
        {
            strSentencia = "truncate table tbVistasTemp";
            cone.mEjecutar(strSentencia, cone);
        }

        public Boolean mInsertar(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Insert into tbUsuario(login,password,nombre,apellido1,apellido2,direccion,tipoIdentificacion,fechaNacimiento,puesto,cedula,creadoPor, fechaCreacion) Values ('" + pEntidadUsuario.getLogin() + "','" + pEntidadUsuario.getPassword()
           + "','" + pEntidadUsuario.getNombre() + "','" + pEntidadUsuario.getApellido1() + "','" + pEntidadUsuario.getApellido2() + "','" + pEntidadUsuario.getDireccion() + "','" + pEntidadUsuario.getTipoIdentificacion()
            + "','" + pEntidadUsuario.getFechaN() + "','" + pEntidadUsuario.getPuesto() + "'," + pEntidadUsuario.getCedula() + ", "+pEntidadUsuario.getIdUsuario()+",getDate())";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo agregar empleado

        public Boolean mModificar(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "update tbUsuario set password='"+pEntidadUsuario.getPassword()+ "', nombre='"+pEntidadUsuario.getNombre()+"', apellido1='"+pEntidadUsuario.getApellido1()+"', apellido2='"+pEntidadUsuario.getApellido2()+
                "', direccion='"+pEntidadUsuario.getDireccion()+"', tipoIdentificacion='"+pEntidadUsuario.getTipoIdentificacion()+"', fechaNacimiento='"+pEntidadUsuario.getFechaN()+"', puesto= '"+pEntidadUsuario.getPuesto()+
                "', cedula= "+pEntidadUsuario.getCedula()+ ", modificadoPor="+pEntidadUsuario.getIdUsuario()+ ", fechaModificacion= getDate() where idUsuario = " + pEntidadUsuario.getIdUsuario() + "";
            return cone.mEjecutar(strSentencia, cone);
        }

        public SqlDataReader mConsultarUsuarioGeneral(clsConexion cone)
        {
            strSentencia = "Select U.idUsuario, U.login from tbUsuario U";
            return cone.mSeleccionar(strSentencia, cone);
        }

        #endregion
    }
}
