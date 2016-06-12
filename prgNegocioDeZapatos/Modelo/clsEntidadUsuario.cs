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

        private String nombre;
        private String apellido;
        private int cedula;
        private String direccion;
        private String fechaNacimiento;
        private String telefono;
        private String email;

        #endregion

        #region Constructor

        public clsEntidadUsuario()
        {

            this.nombre = "";
            this.apellido = "";
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


        public void setApellido(String apellido)
        {

            this.apellido = apellido;
        }

        public String getApellido()
        {
            return this.apellido;
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




        #endregion

    }
}
