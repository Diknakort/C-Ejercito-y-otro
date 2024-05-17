using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public interface IMilitar
    {
        int Precio { get; set; }
        IBlindaje Blindaje { get; set; }
        IMovimiento Velocidad { get; set; }
        IPotencia PotenciaDeFuego { get; set; }
        string Tipo { get; set; }

        void dameEjercito();
        double dameCoefMilitar();
    }
}