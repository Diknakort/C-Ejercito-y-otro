using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MacMapkerson
{
    public interface ISuperUnidad : IMilitar
    {
        public int Precio { get; set; }
        public double Blindaje { get; set; }
        public double Velocidad { get; set; }
        public double PotenciaDeFuego { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }

    }
    public class DecoradorSuperPiloto : ISuperUnidad
    {
        private readonly ISuperUnidad ObjetoADecorar;

        public DecoradorSuperPiloto(ISuperUnidad tank)
        {
            ObjetoADecorar = tank;
        }

        public int Precio
        {
            get => ObjetoADecorar.Precio;
            set => ObjetoADecorar.Precio = value;
        }
        public double Blindaje
        {
            get => ObjetoADecorar.Blindaje;
            set => ObjetoADecorar.Blindaje = value;
        }
        public double Velocidad
        {
            get => ObjetoADecorar.Velocidad * 1.1;
            set => ObjetoADecorar.Velocidad = value;
        }
        public double PotenciaDeFuego
        {
            get => ObjetoADecorar.PotenciaDeFuego;
            set => ObjetoADecorar.PotenciaDeFuego = value;
        }
        public string Tipo
        {
            get => ObjetoADecorar.Tipo;
            set => ObjetoADecorar.Tipo = value;
        }
        public string Nombre
        {
            get => ObjetoADecorar.Tipo + $"{ObjetoADecorar}  (con piloto entrenado) ";
            set => ObjetoADecorar.Tipo = value;
        }

        public double dameCoefMilitar()
        {
            return ObjetoADecorar.dameCoefMilitar();
        }

        public void dameEjercito()
        {
            throw new NotImplementedException();
        }
        public override string? ToString()
        {
            return ($"{ObjetoADecorar.Nombre} (con piloto entrenado)");
        }
    }
    public class DecoradorSuperBomba : ISuperUnidad
    {
        private readonly ISuperUnidad ObjetoADecorar;

        public DecoradorSuperBomba(ISuperUnidad SoldadoUniversal)
        {
            ObjetoADecorar = SoldadoUniversal;
        }

        public int Precio
        {
            get => ObjetoADecorar.Precio;
            set => ObjetoADecorar.Precio = value;
        }
        public double Blindaje
        {
            get => ObjetoADecorar.Blindaje;
            set => ObjetoADecorar.Blindaje = value;
        }
        public double Velocidad
        {
            get => ObjetoADecorar.Velocidad;
            set => ObjetoADecorar.Velocidad = value;
        }
        public double PotenciaDeFuego
        {
            get => ObjetoADecorar.PotenciaDeFuego * 10;
            set => ObjetoADecorar.PotenciaDeFuego = value;
        }
        public string Tipo
        {
            get => ObjetoADecorar.Tipo;
            set => ObjetoADecorar.Tipo = value;
        }
        public string Nombre
        {
            get => ObjetoADecorar.Tipo + $"{ObjetoADecorar} (con super bomba) ";
            set => ObjetoADecorar.Tipo = value;
        }
        public double dameCoefMilitar()
        {
            return ObjetoADecorar.dameCoefMilitar();
        }

        public void dameEjercito()
        {
            throw new NotImplementedException();
        }
        public override string? ToString()
        {
            return ($"{ObjetoADecorar.Nombre} (con super bomba)");
        }
    }
    public class DecoradorArena : ISuperUnidad
    {
        private readonly ISuperUnidad ObjetoADecorar;

        public DecoradorArena(ISuperUnidad SoldadoUniversal)
        {
            ObjetoADecorar = SoldadoUniversal;
        }

        public int Precio
        {
            get => ObjetoADecorar.Precio;
            set => ObjetoADecorar.Precio = value;
        }
        public double Blindaje
        {
            get => ObjetoADecorar.Blindaje;
            set => ObjetoADecorar.Blindaje = value;
        }
        public double Velocidad
        {
            get => ObjetoADecorar.Velocidad * 0.8;
            set => ObjetoADecorar.Velocidad = value;
        }
        public double PotenciaDeFuego
        {
            get => ObjetoADecorar.PotenciaDeFuego;
            set => ObjetoADecorar.PotenciaDeFuego = value;
        }
        public string Tipo
        {
            get => ObjetoADecorar.Tipo;
            set => ObjetoADecorar.Tipo = value;
        }
        public string Nombre
        {
            get => ObjetoADecorar.Tipo + $"{ObjetoADecorar} (pasando por arena) ";
            set => ObjetoADecorar.Tipo = value;
        }
        public double dameCoefMilitar()
        {
            return ObjetoADecorar.dameCoefMilitar();
        }

        public void dameEjercito()
        {
            throw new NotImplementedException();
        }
    }
}