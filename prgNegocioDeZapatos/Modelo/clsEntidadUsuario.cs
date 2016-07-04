using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsEntidadUsuario
    {
        #region Atributos
        #endregion

        #region Constructor
        public clsEntidadUsuario(){}//fin del constructor
        #endregion

        #region Metodos
        public int IdUsuario { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Direccion { get; set; }
        public String TipoIdentificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Puesto { get; set; }
        public int Cedula { get; set; }
        public int CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ModificadoPor { get; set; }
        public DateTime fechaModificacion { get; set; }
        #endregion

    }
}
