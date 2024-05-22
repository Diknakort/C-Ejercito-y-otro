using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class TransporteMX7899 : IMilitar, ISuperUnidad
    {
        public TransporteMX7899()
        {
        }

        public TransporteMX7899(int Precio, double Blindaje, double Velocidad, double PotenciaDeFuego)
        {
            this.Precio = Precio;
            this.Blindaje = Blindaje;
            this.Velocidad = Velocidad;
            this.PotenciaDeFuego = PotenciaDeFuego;
        }

        public int Precio { get; set; } = 4200;
        public double Blindaje { get; set; } = 1.4;
        public double Velocidad { get; set; } = 4.5;
        public double PotenciaDeFuego { get; set; } = 0;
        public string Tipo { get; set; }
        public string Nombre { get; set; } = "Transporte MX 7899";


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