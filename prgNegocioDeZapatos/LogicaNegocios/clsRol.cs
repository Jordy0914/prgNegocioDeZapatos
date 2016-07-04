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
    public class clsRol
    {
        #region Atributos
        private string strSentencia;
        #endregion

        #region Metodos
        public SqlDataReader mConsutarNumeroRol(clsConexion cone)
        {
            this.strSentencia = "Select count(*) from tbRoles";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsutarRol(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            this.strSentencia = "Select * from tbRoles";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public SqlDataReader mConsultarNombreRol(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            strSentencia = "Select R.idRol, R.nombre from tbRoles R where R.nombre = '"+ pEntidadRol.Nombre +"' ";
            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean mInsertarRol(clsConexion cone, clsEntidadRol pEntidadRol, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Insert into tbRoles(nombre,creadoPor,fechaCreacion) values ('" + pEntidadRol.Nombre + "' , "+pEntidadUsuario.IdUsuario+" , getDate())";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mInsertarVista

        public Boolean mModificarRol(clsConexion cone, clsEntidadRol pEntidadRol , clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Update tbRoles set nombre = '"+ pEntidadRol.Nombre + "' , modificadoPor = "+ pEntidadUsuario.IdUsuario +" , fechaModificacion = getDate()  where idRol = " + pEntidadRol.IdRol + "  ";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo modificar
        public Boolean mEliminarRol(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            strSentencia = "Delete from tbRoles where idRol='" + pEntidadRol.IdRol + "'";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mEliminarVista
        #endregion
    }
}
