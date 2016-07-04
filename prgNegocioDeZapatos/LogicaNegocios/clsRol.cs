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
        
        public SqlDataReader mConsultarNombreRol(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            strSentencia = "Select R.nombre from tbRoles R where R.nombre = '"+pEntidadRol.getNombre()+"'";
            return cone.mSeleccionar(strSentencia, cone);
        }



        public SqlDataReader mConsultarRolGeneral(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            strSentencia = "Select * from tbRoles where idRol= '" + pEntidadRol.getIdRol() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }


        public Boolean mInsertarRol(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            strSentencia = "Insert into tbRoles(idRol,nombre) values ('" + pEntidadRol.getIdRol() + "','" + pEntidadRol.getNombre() + "'')";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mInsertarVista

        public Boolean mEliminarRol(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            strSentencia = "Delete from tbRoles where idRol='" + pEntidadRol.getIdRol() + "'";
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo mEliminarVista

        public Boolean mModificarRol(clsConexion cone, clsEntidadRol pEntidadRol)
        {

            strSentencia = "Update tbRoles set nombre='" + pEntidadRol.getNombre() + " where idRol=" + pEntidadRol.getIdRol() + "";

            return cone.mEjecutar(strSentencia, cone);

        }//fin del metodo modificar 


        #endregion

    }
}
