using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class clsEntidadRol
    {

        #region Atributos

        private String nombre;
        private int codigo;
        private int insertar;
        private int eliminar;
        private int consultar;
        private int modificar;

        #endregion


        #region Constructor

        public clsEntidadRol()
        {

            this.nombre = "";
            this.codigo = 0;
            this.insertar = 0;
            this.eliminar = 0;
            this.consultar = 0;
            this.modificar = 0;
        }

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

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;

        }


        public int getCodigo()
        {

            return this.codigo;
        }


        public void setInsertar(int insertar)
        {
            this.insertar = insertar;

        }


        public int getInsertar()
        {

            return this.insertar;
        }

        public void setConsultar(int consultar)
        {
            this.consultar = consultar;

        }


        public int getConsultar()
        {

            return this.consultar;
        }


        public void setModificar(int modificar)
        {
            this.modificar = modificar;

        }


        public int getModificar()
        {

            return this.modificar;
        }


        public void setEliminar(int eliminar)
        {
            this.eliminar = eliminar;

        }


        public int getEliminar()
        {

            return this.eliminar;
        }


        #endregion



    }
}
