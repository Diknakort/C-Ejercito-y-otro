using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace MacMapkerson
{
    //public interface ISuperTank : IMilitar
    //{
    //    public int Precio { get; set; }
    //    public double Blindaje { get; set; }
    //    public double Velocidad { get; set; }
    //    public double PotenciaDeFuego { get; set; }
    //    public string Tipo { get; set; }

    //}
    ////public class DecoradorSuperPiloto: ISuperTank
    ////{
    ////    ISuperTank ObjetoADecorar;
    ////    public DecoradorSuperPiloto(ISuperTank tank)
    ////{
    ////    this.ObjetoADecorar = tank;
    ////}
    ////public int Precio { get; set; }
    ////public double Blindaje { get; set; }
    ////public double Velocidad { get { return this.ObjetoADecorar.Velocidad * 1.1; } set { this.ObjetoADecorar.Velocidad = value; } }
    ////public double PotenciaDeFuego { get; set; }
    ////public string Tipo { get; set; }

    ////double IMilitar.dameCoefMilitar()
    ////{
    ////    return ObjetoADecorar.dameCoefMilitar();
    ////}

    ////void IMilitar.dameEjercito()
    ////{
    ////    throw new NotImplementedException();
    ////}
    ////}
    //public class DecoradorSuperPiloto : ISuperTank
    //{
    //    private readonly ISuperTank ObjetoADecorar;

    //    public DecoradorSuperPiloto(ISuperTank tank)
    //    {
    //        ObjetoADecorar = tank;
    //    }

    //    public int Precio
    //    {
    //        get => ObjetoADecorar.Precio;
    //        set => ObjetoADecorar.Precio = value;
    //    }
    //    public double Blindaje
    //    {
    //        get => ObjetoADecorar.Blindaje;
    //        set => ObjetoADecorar.Blindaje = value;
    //    }
    //    public double Velocidad
    //    {
    //        get => ObjetoADecorar.Velocidad * 1.1;
    //        set => ObjetoADecorar.Velocidad = value;
    //    }
    //    public double PotenciaDeFuego
    //    {
    //        get => ObjetoADecorar.PotenciaDeFuego;
    //        set => ObjetoADecorar.PotenciaDeFuego = value;
    //    }
    //    public string Tipo
    //    {
    //        get => ObjetoADecorar.Tipo;
    //        set => ObjetoADecorar.Tipo = value;
    //    }

    //    public double dameCoefMilitar()
    //    {
    //        return ObjetoADecorar.dameCoefMilitar();
    //    }

    //    public void dameEjercito()
    //    {
    //        throw new NotImplementedException();
    //    }
    //    //public override string? ToString()
    //    //{
    //    //    return ($"Unidad {ObjetoADecorar.Tipo}");
    //    //}
    //}

    ////public class DecoradorSuperBomba : ISuperTank
    ////{
    ////    ISuperTank ObjetoADecorar;
    ////    public DecoradorSuperBomba(ISuperTank tank)
    ////    {
    ////        this.ObjetoADecorar = tank;
    ////    }

    ////    public DecoradorSuperBomba(EnumTipoArma superTanque)
    ////    {
    ////    }

    ////    public int Precio { get; set; }
    ////    public double Blindaje { get; set; }
    ////    public double Velocidad { get; set; }
    ////    public double PotenciaDeFuego { get { return this.ObjetoADecorar.PotenciaDeFuego * 10; } set { this.ObjetoADecorar.Velocidad = value; } }
    ////    public string Tipo { get; set; }

    ////    double IMilitar.dameCoefMilitar()
    ////    {
    ////        return ObjetoADecorar.dameCoefMilitar();
    ////    }

    ////    void IMilitar.dameEjercito()
    ////    {
    ////        throw new NotImplementedException();
    ////    }
    ////}

    //public class DecoradorSuperBomba : ISuperTank
    //{
    //    private readonly ISuperTank ObjetoADecorar;

    //    public DecoradorSuperBomba(ISuperTank tank)
    //    {
    //        ObjetoADecorar = tank;
    //    }

    //    public int Precio
    //    {
    //        get => ObjetoADecorar.Precio;
    //        set => ObjetoADecorar.Precio = value;
    //    }
    //    public double Blindaje
    //    {
    //        get => ObjetoADecorar.Blindaje;
    //        set => ObjetoADecorar.Blindaje = value;
    //    }
    //    public double Velocidad
    //    {
    //        get => ObjetoADecorar.Velocidad;
    //        set => ObjetoADecorar.Velocidad = value;
    //    }
    //    public double PotenciaDeFuego
    //    {
    //        get => ObjetoADecorar.PotenciaDeFuego * 10;
    //        set => ObjetoADecorar.PotenciaDeFuego = value;
    //    }
    //    public string Tipo
    //    {
    //        get => ObjetoADecorar.Tipo;
    //        set => ObjetoADecorar.Tipo = value;
    //    }

    //    public double dameCoefMilitar()
    //    {
    //        return ObjetoADecorar.dameCoefMilitar();
    //    }

    //    public void dameEjercito()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    ////public class DecoradorArena : ISuperTank
    ////{
    ////    ISuperTank ObjetoADecorar;
    ////    public DecoradorArena(ISuperTank tank)
    ////    {
    ////        this.ObjetoADecorar = tank;
    ////    }
    ////    public int Precio { get; set; }
    ////    public double Blindaje { get; set; }
    ////    public double Velocidad { get { return this.ObjetoADecorar.Velocidad * 0.8; } set { this.ObjetoADecorar.Velocidad = value; } }
    ////    public double PotenciaDeFuego { get; set; }
    ////    public string Tipo { get; set; }

    ////    public double dameCoefMilitar()
    ////    {
    ////        return ObjetoADecorar.dameCoefMilitar();
    ////    }

    ////    public void dameEjercito()
    ////    {
    ////        throw new NotImplementedException();
    ////    }
    ////}
    //public class DecoradorArena : ISuperTank
    //{
    //    private readonly ISuperTank ObjetoADecorar;

    //    public DecoradorArena(ISuperTank tank)
    //    {
    //        ObjetoADecorar = tank;
    //    }

    //    public int Precio
    //    {
    //        get => ObjetoADecorar.Precio;
    //        set => ObjetoADecorar.Precio = value;
    //    }
    //    public double Blindaje
    //    {
    //        get => ObjetoADecorar.Blindaje;
    //        set => ObjetoADecorar.Blindaje = value;
    //    }
    //    public double Velocidad
    //    {
    //        get => ObjetoADecorar.Velocidad * 0.8;
    //        set => ObjetoADecorar.Velocidad = value;
    //    }
    //    public double PotenciaDeFuego
    //    {
    //        get => ObjetoADecorar.PotenciaDeFuego;
    //        set => ObjetoADecorar.PotenciaDeFuego = value;
    //    }
    //    public string Tipo
    //    {
    //        get => ObjetoADecorar.Tipo;
    //        set => ObjetoADecorar.Tipo = value;
    //    }

    //    public double dameCoefMilitar()
    //    {
    //        return ObjetoADecorar.dameCoefMilitar();
    //    }

    //    public void dameEjercito()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    public class TanqueAtaqueSombrasVB98 : IMilitar, ISuperUnidad
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
        public string Nombre { get; set; } = "Tanque de Ataque Sombras VB98";

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