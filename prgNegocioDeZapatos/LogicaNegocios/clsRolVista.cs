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
    public class clsRolVista
    {
        #region Atributos
        //Permite las sentencias del SQL Transac
        private string strSentencia;
        //Permite enviar la ejecución de la sentencia al modelo en la clase conexion
        #endregion

        #region Metodos
        public SqlDataReader mConsultarRolesVistasGeneral(clsConexion cone)
        {
            strSentencia = "Select RV.idRol, R.nombre, RV.idVista, V.descripcion " +
                "from tbRolesVistas RV, tbRoles R, tbVistas V " +
                "where RV.idRol = R.idRol " +
                "and RV.idVista = V.idVista ";

            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean insertarRolVista(clsConexion cone, clsEntidadRolesVistas pEntidadRolVista, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Insert into tbRolesVistas (idRol, idVista, insertar, modificar, eliminar, consultar, creadoPor, fechaCreacion) " +
                "values("+ pEntidadRolVista.IdRol +","+ pEntidadRolVista.IdVista +",'"+ pEntidadRolVista.Insertar+ "','"+ pEntidadRolVista.Modificar+ "','"+ pEntidadRolVista.Eliminar +"','"+ pEntidadRolVista.Consultar +"','"+ pEntidadUsuario.IdUsuario +"', getDate())";
            return cone.mEjecutar(strSentencia, cone);
        }
        #endregion
    }
}
