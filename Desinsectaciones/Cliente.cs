using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desinsectaciones
{
    public class Cliente : ICliente
    {
        public string nombre;
        public int telefono;
        public string mail;
        public int CP;

        public void dameCliente()
        {
            throw new System.NotImplementedException();
        }
    }
}