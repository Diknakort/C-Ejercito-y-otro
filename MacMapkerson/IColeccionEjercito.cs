using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public interface IColeccionEjercito
    {
        bool Add(IMilitar elemento);
        int dameCuantos();
        double damePotenciaDeFuegoTotal();
        double dameBlindajeTotal();
        double dameCapMovimiento();
        int dameCosteAcumulado();
        double dameCapacidadMilitar();
        object Listar();
    }
}