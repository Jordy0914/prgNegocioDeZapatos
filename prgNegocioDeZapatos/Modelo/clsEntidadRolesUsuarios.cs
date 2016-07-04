using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadRolesUsuarios
    {
        #region Atributos


        #endregion
        #region Constructor
        public clsEntidadRolesUsuarios()
        {


        }
        #endregion
        #region Metodos
        public int IdRol { get; set; }
        public int IdUsuario { get; set; }
        public Boolean Insertar { get; set; }
        public Boolean Modificar { get; set; }
        public Boolean Eliminar { get; set; }
        public Boolean Consultar { get; set; }
        #endregion

    }
}
