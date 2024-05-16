using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacMapkerson
{
    public interface IFabricaEjercito
    {
        IValidador Validador { get; set; }
        IMilitar DameEjercito(EnumTipoArma tipo);
    }
}