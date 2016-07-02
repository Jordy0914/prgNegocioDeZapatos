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
        private int idRol;
        private int insertar;
        private int eliminar;
        private int consultar;
        private int modificar;
        private int creadoPor;
        private DateTime fechaCreacion;
        private int modificadoPor;
        private DateTime fechaModificacion;
        #endregion

        #region Constructor
        public clsEntidadRol()
        {
            this.nombre = "";
            this.idRol = 0;
            this.insertar = 0;
            this.eliminar = 0;
            this.consultar = 0;
            this.modificar = 0;
            this.creadoPor = 0;
            this.fechaCreacion = DateTime.MaxValue;
            this.modificadoPor = 0;
            this.fechaModificacion = DateTime.MaxValue;
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

        public void setIdRol(int idRol)
        {
            this.idRol = idRol;
        }

        public int getIdRol()
        { 
            return this.idRol;
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
