using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class NoSeMueve : IMovimiento
    {
        public double Movimiento { get ; set ; }
        public double dameMovimiento()
        {
            return Movimiento = 0;
        }
    }
    
}