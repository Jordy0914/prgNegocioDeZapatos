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
        private String login;
        private String password;
        private String nombre;
        private String apellido1;
        private String apellido2;
        private int cedula;
        private String direccion;
        private String tipoIdentificacion;
        private String puesto;
        private String fechaNacimiento;
        private String telefono;
        private String email;

        #endregion

        #region Constructor

        public clsEntidadUsuario()
        {
            this.login = "";
            this.password = "";
            this.nombre = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.tipoIdentificacion = "";
            this.puesto = "";
            this.cedula = 0;
            this.direccion = "";
            this.fechaNacimiento = "";
            this.telefono = "";
            this.email = "";

        }//fin del constructor

        #endregion

        #region Metodos

        public void setNombre(String nombre)
        {

            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }


        public void setApellido1(String apellido1)
        {

            this.apellido1 = apellido1;
        }

        public String getApellido()
        {
            return this.apellido1;
        }

        public void setApellido2(String apellido2)
        {

            this.apellido2 = apellido2;
        }

        public String getApellido2()
        {
            return this.apellido2;
        }

        public void setCedula(int cedula)
        {

            this.cedula = cedula;
        }

        public int getCedula()
        {
            return this.cedula;
        }


        public void setDireccion(String direccion)
        {

            this.direccion = direccion;
        }

        public String getDireccion()
        {
            return this.direccion;
        }


        public void setFechaNacimiento(String fechaNacimiento)
        {

            this.fechaNacimiento = fechaNacimiento;
        }

        public String getFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public void setTelefono(String telefono)
        {

            this.telefono = telefono;
        }

        public String getTelefono()
        {
            return this.telefono;
        }

        public void setEmail(String email)
        {

            this.email = email;
        }

        public String getEmail()
        {
            return this.email;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }

        public String getLogin()
        {
            return this.login;
        }

        public void setPassword (String password)
        {
            this.password = password;
        }

        public String getPassword()
        {
            return this.password;
        }

        public void setTipoIdentificacion(String tipoIdentificacion)
        {
            this.tipoIdentificacion = tipoIdentificacion;
        }

        public String getTipoIdentificacion()
        {
            return this.tipoIdentificacion;
        }

        public void setPuesto(String puesto)
        {
            this.puesto = puesto;
        }

        public String getPuesto()
        {
            return this.puesto;
        }


        #endregion

    }
}
