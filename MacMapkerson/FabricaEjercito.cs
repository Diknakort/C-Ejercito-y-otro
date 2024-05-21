using MacMapkerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public class FabricaEjercito : IFabricaEjercito
    {
        public IValidador Validador { get ; set ; }
        public IMilitar DameEjercito1(EnumTipoArma tipo)
        {
            IMilitar militar = null;
            switch (tipo)
            {
                case EnumTipoArma.TransporteMX7899: militar = new TransporteMX7899(); break;
                case EnumTipoArma.TanqueAtaqueSombrasVB98: militar = new TanqueAtaqueSombrasVB98() ; break;
                case EnumTipoArma.TransporteRapidoTAXIN66: militar = new TransporteRapidoTAXIN66() ; break;
                case EnumTipoArma.Ametrallador: militar = new Ametrallador() ; break;
                case EnumTipoArma.Sanitario: militar = new Sanitario() ; break;
                case EnumTipoArma.CanonAntiaereo: militar = new CanonAntiaereo() ; break;
                case EnumTipoArma.TorpederoMovil: militar = new TorpederoMovil() ; break;
                case EnumTipoArma.Canon: militar = new Canon( ) ; break;
                case EnumTipoArma.SuperTanque: militar =
                        new DecoradorSuperPiloto( new DecoradorArena( new DecoradorSuperBomba( new TanqueAtaqueSombrasVB98()))); break;
                    default: militar = new InfanteriaBasica( 250,  0,  6,  7); break;
            }
            return militar;
        }
    }        
}
//IMilitar militar = null;
//switch (tipo)
//{
//    case EnumTipoArma.TransporteMX7899: militar = new TransporteMX7899(4200, 1.4, 4.5, 0) ; break;
//    case EnumTipoArma.TanqueAtaqueSombrasVB98: militar = new TanqueAtaqueSombrasVB98(15600, 4.8, 7.3, 9.8) ; break;
//    case EnumTipoArma.TransporteRapidoTAXIN66: militar = new TransporteRapidoTAXIN66(1600, 0, 12, 0); break;
//    case EnumTipoArma.Ametrallador: militar = new Ametrallador(400, 0, 4, 10); break;
//    case EnumTipoArma.Sanitario: militar = new Sanitario(500, 5, 7, 0); break;
//    case EnumTipoArma.CanonAntiaereo: militar = new CanonAntiaereo(1100, 0, 1, 22); break;
//    case EnumTipoArma.TorpederoMovil: militar = new TorpederoMovil(1350, 2, 3, 19); break;
//    case EnumTipoArma.Canon: militar = new Canon(1100, 0, 0, 14); break;
//    case EnumTipoArma.SuperTanque:
//        militar =
//            new DecoradorSuperPiloto(new DecoradorArena(new DecoradorSuperBomba(new TanqueAtaqueSombrasVB98(15600, 4.8, 7.3, 9.8)))); break;
//    default: militar = new InfanteriaBasica(250, 0, 6, 7); break;
//}
return militar;