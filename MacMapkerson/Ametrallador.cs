using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class Ametrallador : IMilitar
    {
        public int Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IBlindaje Blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMovimiento Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPotencia PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double dameCoefMilitar()
        {
            throw new NotImplementedException();
        }

        public void dameEjercito()
        {
            throw new NotImplementedException();
        }
    }
}
//        public Ametrallador(int Precio, double Blindaje, double Velocidad, double PotenciaDeFuego)
//        {
//            this.Precio = Precio;
//            this.Blindaje = Blindaje;
//            this.Velocidad = Velocidad;
//            this.PotenciaDeFuego = PotenciaDeFuego;
//        }

//        public int Precio { get; set; }
//        public string Tipo { get; set; }
//        IBlindaje IMilitar.Blindaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        IMovimiento IMilitar.Velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//        IPotencia IMilitar.PotenciaDeFuego { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public double dameCoefMilitar()
//        {
//            return (PotenciaDeFuego * Velocidad) / 2 / (100 - Blindaje);
//        }

//        public void dameEjercito()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}