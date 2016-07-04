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
        #endregion

        #region Constructor
        public clsEntidadRol(){ }
        #endregion

        #region Metodos
        public int IdRol { get; set; }

        public string Nombre { get; set; }

        public int CreadoPor { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int ModificadoPor { get; set; }

        public DateTime FechaModificacion { get; set; }
        #endregion
    }
}
