using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson
{
    public interface ISuperTank
    {
        public int Precio { get; set; }
        public double Blindaje { get; set; }
        public double Velocidad { get; set; }
        public double PotenciaDeFuego { get; set; }
        public string Tipo { get; set; }

    }
    public class DecoradorSuperPiloto
    {
        ISuperTank ObjetoADecorar;
        public DecoradorSuperPiloto(ISuperTank tank)
        {
            this.ObjetoADecorar = tank;
        }
        public int Precio { get ; set ; }
        public double Blindaje { get; set ; }
        public double Velocidad { get { return this.ObjetoADecorar.Velocidad * 1.1; } set { this.ObjetoADecorar.Velocidad = value; } }
        public double PotenciaDeFuego { get ; set ; }
        public string Tipo { get ; set ; }
    }
    public class DecoradorSuperBomba
    {
        ISuperTank ObjetoADecorar;
        //public DecoradorSuperBomba(ISuperTank tank)
        //{
        //    this.ObjetoADecorar = tank;
        //}

        public DecoradorSuperBomba(ISuperTank tank) 
        {
        }

        public int Precio { get; set; }
        public double Blindaje { get; set; }
        public double Velocidad { get; set; }
        public double PotenciaDeFuego { get { return this.ObjetoADecorar.PotenciaDeFuego * 10; } set { this.ObjetoADecorar.Velocidad = value; } }
        public string Tipo { get; set; }
    }
public class DecoradorArena
    {
        ISuperTank ObjetoADecorar;
        public DecoradorArena(ISuperTank tank)
        {
            this.ObjetoADecorar = tank;
        }
        public int Precio { get; set; }
        public double Blindaje { get; set; }
        public double Velocidad { get { return this.ObjetoADecorar.Velocidad * 0.8; } set { this.ObjetoADecorar.Velocidad = value; } }
        public double PotenciaDeFuego { get; set; }
        public string Tipo { get; set; }
    }
    public class TanqueAtaqueSombrasVB98 : IMilitar, ISuperTank
    {
        public TanqueAtaqueSombrasVB98()
        {
        }

        public TanqueAtaqueSombrasVB98(int Precio, double Blindaje, double Velocidad, double PotenciaDeFuego)
        {
            this.Precio = Precio;
            this.Blindaje = Blindaje;
            this.Velocidad = Velocidad;
            this.PotenciaDeFuego = PotenciaDeFuego;
        }

        public int Precio { get; set; } = 15600;
        public double Blindaje { get; set; } = 4.8;
        public double Velocidad { get; set; } = 7.3;
        public double PotenciaDeFuego { get; set; } = 9.8;
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