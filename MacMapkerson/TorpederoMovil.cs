using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class TorpederoMovil : IMilitar
    {
        public TorpederoMovil()
        {
        }

        public TorpederoMovil(int Precio, double Blindaje, double Velocidad, double PotenciaDeFuego)
        {
            this.Precio = Precio;
            this.Blindaje = Blindaje;
            this.Velocidad = Velocidad;
            this.PotenciaDeFuego = PotenciaDeFuego;
        }

        public int Precio { get; set; } = 1350;
        public double Blindaje { get; set; } = 2;
        public double Velocidad { get; set; } = 3;
        public double PotenciaDeFuego { get; set; } = 19;
        public string Tipo { get; set; }
        public double dameCoefMilitar()
        {
            return (PotenciaDeFuego * Velocidad) / 2 / (100 - Blindaje);
        }

        public void dameEjercito()
        {
            throw new NotImplementedException();
        }
    }
}