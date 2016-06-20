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
        private int _idVista;
        private String _nombre;
        private int _creadoPor;
        private int _modificadoPor;
        #endregion


        #region Constructores
        public clsEntidadVista()
        {
            
        }


        public clsEntidadVista(int idVista,String nombre,int creadoPor,int modificadoPor)
        {
            this._idVista = idVista;
            this._nombre = nombre;
            this._creadoPor = creadoPor;
            this._modificadoPor = modificadoPor;
        }

        #endregion


        #region Metodos
        public int idVista
        {
            get { return idVista; }
            set { idVista = value; }
        }

        public string nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int creadoPor
        {
            get { return idVista; }
            set { idVista = value; }
        }

        public int modificadoPor
        {
            get { return idVista; }
            set { idVista = value; }
        }

        #endregion
    }
}
