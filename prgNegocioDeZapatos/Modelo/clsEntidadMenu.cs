using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadMenu
    {

        #region Atributos
        private int idMenu;
        private int idMenuPadre;
        private string descripcion;
        private int posicion;
        private int habilitadoMenu;
        private string url;
        #endregion


        #region Constructores
        public clsEntidadMenu()
        {
            this.idMenu = -1;
            this.idMenuPadre = -1;
            this.descripcion = "";
            this.posicion = -1;
            this.habilitadoMenu = -1;
            this.url = "";   
        }
        #endregion


        #region Metodos
        public void setIdMenu(int idMenu)
        {
            this.idMenu = idMenu;
        }

        public int getIdMenu()
        {
            return this.idMenu;
        }

        public void setIdMenuPadre(int idMenuPadre)
        {
            this.idMenuPadre = idMenuPadre;
        }

        public int getIdMenuPadre()
        {
            return this.idMenuPadre;
        }
        
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public void setPosicion(int posicion)
        {
            this.posicion = posicion;
        }

        public int getPosicion ()
        {
            return this.posicion;
        }
        
        public void setHabilitadoMenu(int habilitadoMenu)
        {
            this.habilitadoMenu = habilitadoMenu;
        }

        public int getHabilitadoMenu()
        {
            return this.habilitadoMenu;
        }

        public void setUrl(string url)
        {
            this.url = url;
        }

        public string getUrl()
        {
            return this.url;
        }

        #endregion
    }
}
