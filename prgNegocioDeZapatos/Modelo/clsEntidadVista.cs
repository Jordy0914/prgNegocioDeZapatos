using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadVista
    {
        #region Atributos
        private int idVista;
        private int idPadre;
        private string descripcion;
        private int posicion;
        private int habilitadoMenu;
        private string url;
        #endregion

        #region Constructores
        public clsEntidadVista()
        {
            this.idVista = -1;
            this.idPadre = -1;
            this.descripcion = "";
            this.posicion = -1;
            this.habilitadoMenu = -1;
            this.url = "";   
        }
        #endregion

        #region Metodos
        public void setIdVista(int idVista)
        {
            this.idVista = idVista;
        }

        public int getIdVista()
        {
            return this.idVista;
        }

        public void setIdPadre(int idPadre)
        {
            this.idPadre = idPadre;
        }

        public int getIdPadre()
        {
            return this.idPadre;
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
