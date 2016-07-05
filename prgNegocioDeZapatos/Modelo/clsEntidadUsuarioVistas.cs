using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadUsuarioVistas
    {
        #region Atributos
        #endregion

        #region Constructor
        public clsEntidadUsuarioVistas() { }
        #endregion

        #region Metodos 
        #endregion
        public int IdUsuario { get; set; }
        public int IdVista { get; set; }
        public Boolean Insertar { get; set; }
        public Boolean Modificar { get; set; }
        public Boolean Eliminar { get; set; }
        public Boolean Consultar { get; set; }
    }
}
