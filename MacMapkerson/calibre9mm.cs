using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class calibre9mm : IPotencia
    {
        public double potencia = 9;

        public double PotenciaDeFuego
        {
            get => default;
            set
            {
            }
        }

        public double damePotencia()
        {
            return potencia;
        }
    }
}