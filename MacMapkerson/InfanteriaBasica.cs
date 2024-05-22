using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class InfanteriaBasica : IMilitar, ISuperUnidad
    {
        public InfanteriaBasica(int Precio, double Blindaje, double Velocidad, double PotenciaDeFuego)
        {
            this.Precio = Precio;
            this.Blindaje = Blindaje;
            this.Velocidad = Velocidad;
            this.PotenciaDeFuego = PotenciaDeFuego;
        }

        public int Precio { get; set; }
        public double Blindaje { get; set; }
        public double Velocidad { get; set; }
        public double PotenciaDeFuego { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; } = "Infanteria Basica";


        public double dameCoefMilitar()
        {
            return (PotenciaDeFuego * Velocidad) / 2 / (100 - Blindaje);
        }

        public void dameEjercito()
        {
            throw new NotImplementedException();
        }
        public override string? ToString()
        {
            return ($"La unidad seleccionada es: {Nombre}");
        }
    }
}