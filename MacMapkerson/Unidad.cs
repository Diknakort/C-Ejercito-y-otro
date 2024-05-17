using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MacMapkerson
{
    public class Unidad : IMilitar
    {
        public IMovimiento _sistemaMovimiento;
        public IBlindaje _sistemaBlindaje;
        public IPotencia _sistemaPotencia;

        public Unidad()
        {
        }

        public int Precio { get; set; }
        public string Tipo { get; set; }
        public IBlindaje Blindaje { get ; set ; }
        public IMovimiento Velocidad { get ; set ; }
        public IPotencia PotenciaDeFuego { get ; set ; }

        //public double Blindaje { get ; set; }
        //public double Velocidad { get ; set ; }
        //public double PotenciaDeFuego { get ; set ; }


        public double dameCoefMilitar()
        {
            return (IPotencia.PotenciaDeFuego * Velocidad) / 2 / (100 - this.Blindaje);
        }

        public void dameEjercito()
        {
            throw new NotImplementedException();
        }

        public double dameMovimiento()
        {
            return _sistemaMovimiento.dameMovimiento(); 
        }
        public double damePotencia()
        {
            return _sistemaPotencia.damePotencia();
        }
        //public double dameBlindaje()
        //{
        //    return _sistemaBlindaje.dameBlindaje();
        //}
    }
}