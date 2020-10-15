using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto03_Sanchez_Zepeda
{
    public class Individuo
    {


        public int[] c = new int[30];



        public int Sumatoria()
        {
            int sumatoria = 0;

            sumatoria = c.Sum();

            return sumatoria;
        }

        //-------------- Esta era la variabilidad original pero a la hora de programarla resulto muy muy lenta por lo que tuvimos que utilizar otra 
        //public double Variabilidad()
        //{
        //    double[] repeticiones = new double[15];
        //    for (int i = 0; i < 15; i++)
        //        repeticiones[i] = 0;
        //    for (int i = 0; i < 30; i++)
        //    {
        //        repeticiones[c[i] - 1] += 1;
        //    }

        //    double nd = 0;
        //    for (int i = 0; i < 15; i++)
        //    {
        //        if (repeticiones[i] != 0)
        //            nd += 1;
        //    }
        //    double var = 0;
        //    double maxRep = 0;
        //    maxRep = repeticiones.Max();

        //    var = nd / maxRep;

        //    return var / 7.5;
        //}

        public void Cruzas(Individuo P, Individuo Z)
        {
            for (int i = 0; i < 15; i++)
            {
                c[(2 * i) + 1] = P.c[(2 * i) + 1];
                c[2 * i] = Z.c[2 * i];
            }

        }



        public double Variabilidad()
        {
            double[] repeticiones = new double[15];
            for (int i = 0; i < 15; i++)
                repeticiones[i] = 0;
            for (int i = 0; i < 30; i++)
            {
                repeticiones[c[i] - 1] += 1;
            }
            double var = 0;
            for (int i = 0; i < 15; i++)
                var += ((repeticiones[i]) * (repeticiones[i]) * repeticiones[i]);
            return (120 / var);
        }


    }
}
