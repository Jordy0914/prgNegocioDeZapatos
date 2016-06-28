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



        #region Atributos

        public SqlDataReader mConsultarRolNombre(clsConexion cone)
        {
            strSentencia = "Select * from tbRoles";
            return cone.mSeleccionar(strSentencia, cone);
        }


        public SqlDataReader mConsultarRolGeneral(clsConexion cone, clsEntidadRol pEntidadRol)
        {
            strSentencia = "Select * from tbRoles where idRol= '" + pEntidadRol.getIdRol() + "'";
            return cone.mSeleccionar(strSentencia, cone);
        }


        #endregion

    }
}
