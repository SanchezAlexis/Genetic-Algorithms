using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto03_Sanchez_Zepeda
{
    class Pobblacion
    {
        public List<Individuo> listaindividuos = new List<Individuo>();
        public Individuo mI;
        Random r;

        public Pobblacion(Random r)
        {
            this.r = r;
        }

        public void ordenar()
        {
            listaindividuos.Sort(new Ordenar());
            mI = listaindividuos[0];
        }

        public void GenerarI()
        {
            Individuo x = new Individuo();
            for (int i = 0; i < 30; i++)
            {
                x.c[i] = r.Next(1, 16);

            }
            listaindividuos.Add(x);

        }
        // -----------------OPERADORES GENETICOS DE MUTA Y CRUZA----------------------------------
        public void Mutar()
        {

            if (r.Next(0, 10) == 1 || r.Next(0, 10) == 3 || r.Next(0, 10) == 5 || r.Next(0, 10) == 7 || r.Next(0, 10) == 9)
            {
                for (int j = 0; j < 8; j++)
                {
                    int i = r.Next(0, 100);
                    int c = r.Next(0, 30);
                    int g = r.Next(1, 16);
                    listaindividuos[i].c[c] = g;
                }
            }

        }

        public void Cruzar(int j, int m)
        {
            ordenar();
            int contador = 0;
            Individuo reproduccion = new Individuo();
            reproduccion.Cruzas(listaindividuos[j], listaindividuos[m]);
            listaindividuos.Add(reproduccion);
            contador++;

        }

    }
}
