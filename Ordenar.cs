using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto03_Sanchez_Zepeda
{
    public class Ordenar : IComparer<Individuo>//Clase que sirve para ordenar los individuos por generacion 
    {
        public int Compare(Individuo x, Individuo y)
        {
            if (x.Variabilidad() < y.Variabilidad())
            {
                return 1;
            }
            if (x.Variabilidad() > y.Variabilidad())
            {
                return -1;
            }

            if (x.Sumatoria() < y.Sumatoria())
            {
                return 1;
            }
            if (x.Sumatoria() > y.Sumatoria())
            {
                return -1;
            }
            return 0;

        }

    }

}
