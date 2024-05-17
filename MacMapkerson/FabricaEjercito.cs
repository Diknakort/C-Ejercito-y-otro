using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class FabricaEjercito : IFabricaEjercito
    {
        public IValidador Validador { get ; set ; }
        public IMilitar DameEjercito(EnumTipoArma tipo)
        {
            IMilitar militar = null;
            switch (tipo)
            {
                case EnumTipoArma.TransporteMX7899:
                    militar = new Unidad() { Precio = 4200};
                    ; break;
                case EnumTipoArma.TanqueAtaqueSombrasVB98: militar = new Unidad() 
                { _sistemaBlindaje = new Blindado(), Precio = 15600 , _sistemaMovimiento = new SeMueve() { Movimiento = 5}, _sistemaPotencia = new Calibre105()}; break;
                case EnumTipoArma.TransporteRapidoTAXIN66: militar = new Unidad()
                { _sistemaBlindaje = new Blindado(), Precio = 1600, _sistemaMovimiento = new SeMueve(), _sistemaPotencia = new calibre9mm() }; break;
                case EnumTipoArma.Ametrallador: militar = new Unidad()
                { _sistemaBlindaje = new Blindado(), Precio = 400, _sistemaMovimiento = new SeMueve(), _sistemaPotencia = new calibre9mm() }; break;
                case EnumTipoArma.Sanitario: militar = new Unidad()
                { _sistemaBlindaje = new Blindado(), Precio = 500, _sistemaMovimiento = new SeMueve(), _sistemaPotencia = new calibre9mm() }; break;
                case EnumTipoArma.CanonAntiaereo: militar = new Unidad()
                { _sistemaBlindaje = new Blindado(), Precio = 1100, _sistemaMovimiento = new NoSeMueve(), _sistemaPotencia = new calibre9mm() }; break;
                case EnumTipoArma.TorpederoMovil: militar = new Unidad() 
                { _sistemaBlindaje = new Blindado(), Precio = 1350, _sistemaMovimiento = new SeMueve(), _sistemaPotencia = new calibre9mm() }; break;
                case EnumTipoArma.Canon: militar = new Unidad() 
                { _sistemaBlindaje = new Blindado(), Precio = 1100, _sistemaMovimiento = new SeMueve(), _sistemaPotencia = new calibre9mm() }; break;
                default: militar = new Unidad() { Precio = 250, _sistemaMovimiento = new SeMueve(), _sistemaPotencia = new calibre9mm() }; break;

                    //case EnumTipoArma.TransporteMX7899: militar = new Unidad(4200, 1.4, 4.5, 0); break;
                    //case EnumTipoArma.TanqueAtaqueSombrasVB98: militar = new Unidad(15600, 4.8, 7.3, 9.8); break;
                    //case EnumTipoArma.TransporteRapidoTAXIN66: militar = new Unidad(1600,  0,  12,  0); break;
                    //case EnumTipoArma.Ametrallador: militar = new Unidad( 400,  0,  4,  10); break;
                    //case EnumTipoArma.Sanitario: militar = new Unidad(500, 5, 7, 0); break;
                    //case EnumTipoArma.CanonAntiaereo: militar = new Unidad(1100, 0, 1, 22); break;
                    //case EnumTipoArma.TorpederoMovil: militar = new Unidad(1350, 2, 3, 19); break;
                    //case EnumTipoArma.Canon: militar = new Unidad( 1100,  0,  0,  14); break;
                    //    default: militar = new Unidad( 250,  0,  6,  7); break;
            }
            return militar;
        }
    }        
}
