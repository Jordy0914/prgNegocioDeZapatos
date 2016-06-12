using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class clsEntidadProveedor
    {


        #region Atributos

        private int codigo;
        private String nombre;
        private String telefono;
        private String direccion;
        private String email;

        #endregion


        #region Constructor

        public clsEntidadProveedor()
        {
            this.codigo = 0;
            this.nombre="";
            this.telefono="";
            this.direccion="";
            this.email = "";

       }

        #endregion


        #region Metodos

        public void setCodigo(int codigo)
        {

            this.codigo = codigo;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setNombre(String nombre)
        {

            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setDireccion(String direccion)
        {

            this.direccion = direccion;
        }

        public String getDireccion()
        {
            return this.direccion;
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
