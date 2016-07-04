using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadRolesVistas
    {
        #region Atributos
        #endregion

        #region Constructor
        public clsEntidadRolesVistas() { }
        #endregion

        #region Metodos 
        #endregion
        public int IdRol {get;set;}
        public int IdVista {get; set;}
        public Boolean Insertar { get; set; }
        public Boolean Modificar { get; set; }
        public Boolean Eliminar { get; set; }
        public Boolean Consultar { get; set; }
    }
}
