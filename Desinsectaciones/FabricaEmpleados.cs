using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desinsectaciones
{
    public class FabricaEmpleados : IFabricaEmpleados
    {
        public bool Validador { get ; set ; }


        IDesinsecta IFabricaEmpleados.dameEmpleado(EnumTipoEmpleado tipo)
                {
                IDesinsecta empleado = null;
                switch (tipo)
                {
                    case EnumTipoEmpleado.Gerente: empleado = new Gerente() { sueldo = 50 }; break;
                    case EnumTipoEmpleado.JefeEquipo: empleado = new JefeEquipo() { sueldo = 30 }; break;
                        default: empleado = new Peon() { sueldo = 20 }; break;
                }
                return empleado;
            }
        }
}