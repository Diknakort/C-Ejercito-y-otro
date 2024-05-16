using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Desinsectaciones
{
    public class ValidadorVeneno : IValidador
    {
        public bool isValid(IDesinsecta elemento)
        {
            return elemento.costeVeneno < 2;
               
        }
    }
}