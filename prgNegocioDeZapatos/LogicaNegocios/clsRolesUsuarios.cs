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
        public Boolean insertarRolUsuario(clsConexion cone, clsEntidadRolesUsuarios pEntidadRolesUsuarios, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Insert into tbRolesVistas (idRol, idVista, insertar, modificar, eliminar, consultar, creadoPor, fechaCreacion) " +
                "values(" + pEntidadRolesUsuarios.IdRol + "," + pEntidadRolesUsuarios.IdUsuario + ",'" + pEntidadRolesUsuarios.Insertar + "','" + pEntidadRolesUsuarios.Modificar + "','" + pEntidadRolesUsuarios.Eliminar + "','" + pEntidadRolesUsuarios.Consultar + "','" + pEntidadUsuario.IdUsuario + "', getDate())";
            return cone.mEjecutar(strSentencia, cone);
        }

        #endregion

    }
}
