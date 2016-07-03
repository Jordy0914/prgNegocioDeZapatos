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
        #endregion

        #region Constructores
        public clsEntidadVista() { }
        #endregion

        #region Metodos
        public int IdVista { get; set; }

        public int IdPadre { get; set; }

        public string Descripcion { get; set; }

        public int Posicion { get; set; }

        public int HabilitadoMenu { get;set; }

        public string Url { get; set; }

        public int Insertar { get; set; }

        public int Modificar { get; set;}

        public int Eliminar { get; set; }

        public int Consultar { get; set; }
        #endregion
    }
}
