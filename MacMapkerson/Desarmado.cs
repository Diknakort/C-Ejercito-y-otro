using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class Desarmado : IPotencia
    {
        public double PotenciaDeFuego { get ; set ; }
        public double damePotencia()
        {
            return PotenciaDeFuego=0;
        }
    }
}