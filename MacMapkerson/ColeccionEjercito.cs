﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class ColeccionEjercito : IColeccionEjercito
    {
        List<IMilitar> militarList = new List<IMilitar>();

        double totalCapacidadMilitar = 0;
        double totalVelocidad = 0;
        double TotalPotenciaDeFuego =0;
        int numeroUnidades = 0;
        int totalPrecio = 0;
        double totalBlindaje = 0;

        bool IColeccionEjercito.Add(IMilitar elemento)
        {
            if (elemento != null)
            {
                militarList.Add(elemento);
                numeroUnidades++;
                totalPrecio += elemento.Precio;
                totalVelocidad += elemento.Velocidad;
                TotalPotenciaDeFuego += elemento.PotenciaDeFuego;
                totalBlindaje += elemento.Blindaje;
                totalCapacidadMilitar += elemento.dameCoefMilitar();
                return true;
            }
            return false;
        }

        public double dameBlindajeTotal()
        {
            return totalBlindaje;
        }

        public double dameCapacidadMilitar()
        {
            return (TotalPotenciaDeFuego * totalVelocidad) / 2 / (100 - totalBlindaje);

        }

        public double dameCapMovimiento()
        {
            return totalVelocidad;
        }

        public int dameCosteAcumulado()
        {
            return totalPrecio;
        }

        public int dameCuantos()
        {
            return numeroUnidades;
        }

        public double damePotenciaDeFuegoTotal()
        {
            return TotalPotenciaDeFuego;
        }

        object IColeccionEjercito.Listar()
        {
            foreach (var item in militarList)
            {
                Console.WriteLine(item);
            }
            return this;
        }
    }
}