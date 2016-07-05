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
    public class clsRolesUsuarios
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos
        public Boolean insertarRolUsuario(clsConexion cone, clsEntidadRol pEntidadRol, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Insert into tbUsuariosRoles (idUsuario, idRol, creadoPor, fechaCreacion) " +
                "values(" + pEntidadUsuario.getIdUsuario() + "," + pEntidadRol.IdRol + "," + pEntidadUsuario.getIdUsuario() + ", getDate())";
            return cone.mEjecutar(strSentencia, cone);
        }

        public Boolean modificarRolUsuario(clsConexion cone, clsEntidadRol pEntidadRol, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Update tbUsuariosRoles set idRol="+pEntidadRol.IdRol+", modificadoPor="+pEntidadUsuario.getIdUsuario()+",getDate() where idRol="+pEntidadRol.IdRol+"";
            return cone.mEjecutar(strSentencia, cone);
        }

        public Boolean eliminarRolUsuario(clsConexion cone,clsEntidadRol pEntidadRol,clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Delete from tbUsuarioRol where idRol="+pEntidadRol.IdRol+"";
            return cone.mEjecutar(strSentencia,cone);
        }


        #endregion

    } 
}
