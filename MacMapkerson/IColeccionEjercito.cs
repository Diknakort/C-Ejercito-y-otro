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
        double dameCapacidadMilitar();
        object Listar();
    }
}