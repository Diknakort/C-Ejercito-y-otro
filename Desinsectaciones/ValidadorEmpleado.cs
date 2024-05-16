using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desinsectaciones
{
    public class ValidadorEmpleado : IValidador
    {
        public bool isValid(IDesinsecta elemento)
        {
            return elemento.sueldo <50;
        }
    }
}