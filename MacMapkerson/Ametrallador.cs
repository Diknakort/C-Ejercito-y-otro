using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class Ametrallador : IMilitar
    {

        //public Ametrallador(int Precio, double Blindaje, double Velocidad, double PotenciaDeFuego)
        //{
        //    this.Precio = Precio;
        //    this.Blindaje = Blindaje;
        //    this.Velocidad = Velocidad;
        //    this.PotenciaDeFuego = PotenciaDeFuego;
        //}
        public int Precio { get; set; } = 400;
        public double Blindaje { get; set; } = 0;
        public double Velocidad { get; set; } = 4;
        public double PotenciaDeFuego { get; set; } = 10;
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