using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace MacMapkerson
{
    public class CanonAntiaereo : IMilitar, ISuperUnidad
    {
        public CanonAntiaereo()
        {
        }

        public CanonAntiaereo(int Precio, double Blindaje, double Velocidad, double PotenciaDeFuego)
        {
            this.Precio = Precio;
            this.Blindaje = Blindaje;
            this.Velocidad = Velocidad;
            this.PotenciaDeFuego = PotenciaDeFuego;
        }
        public int Precio { get; set; } = 1100;
        public double Blindaje { get; set; } = 0;
        public double Velocidad { get; set; } = 1;
        public double PotenciaDeFuego { get; set; } = 22;
        public string Tipo { get; set; }
        public string Nombre { get; set; } = "Canon Antiaereo";


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