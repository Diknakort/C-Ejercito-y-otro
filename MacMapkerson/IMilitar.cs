using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public interface IMilitar
    {
        int Precio { get; set; }
        double Blindaje { get; set; }
        double Velocidad { get; set; }
        double PotenciaDeFuego { get; set; }
        string Tipo { get; set; }

        void dameEjercito();
        double dameCoefMilitar();
    }
}