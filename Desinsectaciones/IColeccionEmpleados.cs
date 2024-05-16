using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desinsectaciones
{
    public interface IColeccionEmpleados
    {
        int gastoEquipo(int sueldoJefe, int sueldoPeon);
        bool Add();
        double gastoEmpresa();
        double facturacionTotal();
        bool Add(IDesinsecta elemento);
    }
}