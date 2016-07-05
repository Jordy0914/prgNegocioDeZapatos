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
    public class clsUsuarioVista
    {
        #region Atributos
        //Permite las sentencias del SQL Transac
        private string strSentencia;
        //Permite enviar la ejecución de la sentencia al modelo en la clase conexion
        #endregion

        #region Metodos
        public SqlDataReader mConsultarUsuarioVistaGeneral(clsConexion cone)
        {
            strSentencia = "Select UV.idUsuario, U.login, UV.idVista, V.descripcion, UV.insertar, UV.modificar, UV.eliminar, UV.consultar " +
                "from tbUsuarioVistas UV, tbUsuario U, tbVistas V " +
                "where UV.idVista = V.idVista " +
                "and UV.idUsuario = U.idUsuario";

            return cone.mSeleccionar(strSentencia, cone);
        }

        public Boolean mInsertarUsuarioVista(clsConexion cone, clsEntidadUsuarioVistas pEntidadUsuarioVistas, clsEntidadUsuario pEntidadUsuarios)
        {
            strSentencia = "Insert into tbUsuarioVistas (idUsuario, idVista, insertar, modificar, eliminar, consultar, creadoPor, fechaCreacion) " +
                 "values(" + pEntidadUsuarioVistas.IdUsuario + "," + pEntidadUsuarioVistas.IdVista + ",'" + pEntidadUsuarioVistas.Insertar + "','" + pEntidadUsuarioVistas.Modificar + "','" + pEntidadUsuarioVistas.Eliminar + "','" + pEntidadUsuarioVistas.Consultar + "','" + pEntidadUsuarioVistas.IdUsuario + "', getDate())";
            return cone.mEjecutar(strSentencia, cone);
        }

        public Boolean mModificarConVista(clsConexion cone, clsEntidadUsuarioVistas pEntidadUsuarioVistas, clsEntidadUsuario pEntidadUsuario, int idVista)
        {
            strSentencia = "Update tbUsuarioVistas set idVista = " + pEntidadUsuarioVistas.IdVista + " , insertar = '" + pEntidadUsuarioVistas.Insertar + "', modificar = '" + pEntidadUsuarioVistas.Modificar + "', eliminar = '" + pEntidadUsuarioVistas.Eliminar + "', consultar = '" + pEntidadUsuarioVistas.Consultar + "', modificadoPor = '" + pEntidadUsuario.IdUsuario + "', fechaModificacion = getDate() where idUsuario = " + pEntidadUsuarioVistas.IdUsuario + " and idVista = " + idVista + " ";
            return cone.mEjecutar(strSentencia, cone);
        }

        public Boolean mModificarSinVista(clsConexion cone, clsEntidadUsuarioVistas pEntidadUsuarioVistas, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Update tbUsuarioVistas set insertar = '" + pEntidadUsuarioVistas.Insertar + "', modificar = '" + pEntidadUsuarioVistas.Modificar + "', eliminar = '" + pEntidadUsuarioVistas.Eliminar + "', consultar = '" + pEntidadUsuarioVistas.Consultar + "', modificadoPor = '" + pEntidadUsuario.IdUsuario + "', fechaModificacion = getDate() where idUsuario = " + pEntidadUsuarioVistas.IdUsuario + " and idVista = " + pEntidadUsuarioVistas.IdVista + "";
            return cone.mEjecutar(strSentencia, cone);
        }
        public Boolean mEliminarUsuarioVista(clsConexion cone, clsEntidadUsuarioVistas pEntidadUsuarioVistas)
        {
            strSentencia = "Delete from tbUsuarioVistas where idUsuario = " + pEntidadUsuarioVistas.IdUsuario + " and idVista = " + pEntidadUsuarioVistas.IdVista + " ";
            return cone.mEjecutar(strSentencia, cone);
        }

        #endregion
    }
}
