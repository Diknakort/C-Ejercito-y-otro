using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desinsectaciones
{
    public class ColeccionEmpleados : IColeccionEmpleados
    {
        List<IDesinsecta> plantilla = new List<IDesinsecta>();

        int numeroEmpleados = 0;
        int totalSueldos = 0;

        bool IColeccionEmpleados.Add(IDesinsecta elemento)
        {
            if (elemento != null)
            {
                plantilla.Add(elemento);
                numeroEmpleados++;
                totalSueldos += elemento.sueldo;

                return true;
            }
            return false;
        }
        public double facturacionTotal()
        {
            throw new NotImplementedException();
        }

        public double gastoEmpresa()
        {
            return sueldoGerente + gastoEquipo();
        }

        public int gastoEquipo(int sueldoJefe, int sueldoPeon)
        {
            return sueldoJefe + (sueldoPeon * numeroEmpleados);
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }
    }
}