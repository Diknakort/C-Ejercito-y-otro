using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desinsectaciones
{
    public interface IFabricaEmpleados
    {
        bool Validador { get; set; }
        IDesinsecta dameEmpleado(EnumTipoEmpleado tipo);
    }
}