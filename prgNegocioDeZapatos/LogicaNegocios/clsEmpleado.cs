using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using AccesoDatos;

namespace LogicaNegocios
{
   public class clsEmpleado
    {

        #region Atributos
        //Permite las sentencias del SQL Transac
        private string strSentencia;
        //Permite enviar la ejecución de la sentencia al modelo en la clase conexion
        #endregion


        #region Metodos


        public Boolean mAgregarEmpleado(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Insert into tbEmpleado(nombre,apellido1,apellido2,direccion,tipoIdentificacion,fechaNacimiento,puesto,cedula) Values ('"+pEntidadUsuario.getNombre()+ "','"+pEntidadUsuario.getApellido()
            +",'"+pEntidadUsuario.getApellido2()+"','"+pEntidadUsuario.getDireccion()+"','"+pEntidadUsuario.getTipoIdentificacion()
            +"','"+pEntidadUsuario.getFechaNacimiento()+"','"+pEntidadUsuario.getPuesto()+"','"+pEntidadUsuario.getCedula()+"'')";
                 
            return cone.mEjecutar(strSentencia, cone);
        }//fin del metodo agregar empleado


        #endregion

    }
}
