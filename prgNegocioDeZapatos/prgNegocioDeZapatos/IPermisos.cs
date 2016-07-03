using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgNegocioDeZapatos
{
    interface IPermisos
    {
        void activarInsertar(Boolean condicion);

        void activarModificar(Boolean condicion);

        void activarEliminar(Boolean condicion);

        void activarConsultar(Boolean condicion);
    }
}
