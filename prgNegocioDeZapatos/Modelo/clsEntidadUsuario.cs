using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadUsuario
    {
        #region Atributos
        public int IdUsuario;
        public String login;
        public String password;
        public String nombre;
        public String apellido1;
        public String apellido2;
        public String direccion;
        public String tipoIdentificacion;
        public DateTime fechaNacimiento;
        public String puesto;
        public int cedula;
        public int creadoPor;
        public DateTime fechaCreacion;
        public int modificadoPor;
        public DateTime fechaModificacion;
        #endregion

        #region Constructor
        public clsEntidadUsuario(){}//fin del constructor
        #endregion

        #region Metodos
        public void setIdUsuario (int idUsuario)
        {
            this.IdUsuario = idUsuario;
        }

        public int getIdUsuario()
        {
            return IdUsuario;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }

        public String getLogin()
        {
            return login;
        }

        public void setPassword(String password)
        {
            this.password = password.Trim();
        }

        public String getPassword()
        {
            return password;
        }

        public void setNombre(String nombre )
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return nombre;       }

        public void setApellido1(String apellido1 )
        {
            this.apellido1 = apellido1;
        }

        public String getApellido1()
        {
            return apellido1;
        }

        public void setApellido2(String apellido2)
        {
            this.apellido2 = apellido2;
        }

        public String getApellido2()
        {
            return apellido2;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public void setTipoIdentificacion(String tipo)
        {
            this.tipoIdentificacion = tipo;
        }

        public String getTipoIdentificacion()
        {
            return tipoIdentificacion;
        }

        public void setFechaN(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public DateTime getFechaN()
        {
            return fechaNacimiento;
        }

        public void setPuesto(String puesto)
        {
            this.puesto = puesto;
        }

        public String getPuesto()
        {
            return puesto;
        }

        public void setCedula(int cedula)
        {
            this.cedula = cedula;
        }

        public int getCedula()
        {
            return cedula;
        }

        public void setCreadoPor(int creadoPor)
        {
            this.creadoPor = creadoPor;

        }

        public int getCreadoPor()
        {

            return creadoPor;
        }


        public void setFechaCreacion(DateTime fechaCreacion)
        {
            this.fechaCreacion = fechaCreacion;
        }


        public DateTime getFechaCreacion()
        {

            return fechaCreacion;
        }

        public void setModificadoPor(int modificadoPor)
        {
            this.modificadoPor = modificadoPor;

        }

        public int getModificadoPor()
        {

            return modificadoPor;
        }


        public void setFechaModificacion(DateTime fechaModificacion)
        {
            this.fechaModificacion = fechaModificacion;
        }


        public DateTime getFechaModificacion()
        {

            return fechaModificacion;
        }



        #endregion

    }
}
