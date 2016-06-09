using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsEntidadUsuario
    {

        #region Atributos

        private String nombre;
        private String apellido;
        private int cedula;
        private String direccion;
        private String fechaNacimiento;

        #endregion

        #region Constructor

        public clsEntidadUsuario()
        {

            this.nombre = "";
            this.apellido = "";
            this.cedula = 0;
            this.direccion = "";
            this.fechaNacimiento = "";

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

        #endregion

    }
}
