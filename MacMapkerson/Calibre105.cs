using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class Calibre105 : IPotencia
    {
        public double PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double damePotencia()
        {
            return PotenciaDeFuego=105;
        }
    }
}