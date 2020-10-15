using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto03_Sanchez_Zepeda
{
    class Ciclo
    {
        public static int Elitismo(Random randomr)
        {
            int x = 0;
            x = randomr.Next(0, 2001);
            if (x < 1000)
            {
                x = randomr.Next(0, 10);
            }
            else if (x > 999 && x <= 1500)
            {
                x = randomr.Next(10, 41);
            }
            else if (x <= 1750 && x > 1500)
            {
                x = randomr.Next(41, 61);
            }
            else if (x <= 1876 && x > 1750)
            {
                x = randomr.Next(61, 85);
            }
            else if (x > 1876)
            {
                x = randomr.Next(85, 100);
            }
            return x;
        }

        public bool Stop()//CRITERIO DE STOP: Llegar a variablidad de 1 
        {
            bool s = false;
            if (best.Variabilidad() == 1)
                s = true;
            return s;
        }

        public List<Pobblacion> generaciones = new List<Pobblacion>();
        public Individuo best;
        public int gene = 0;
        Random r;

        public Ciclo(Random r)
        {
            this.r = r;
        }

        public void GenerarPob()
        {
            Pobblacion pob = new Pobblacion(r);
            if (gene == 0)
            {
                for (int i = 0; i < 100; i++)
                    pob.GenerarI();
                generaciones.Add(pob);
                pob.ordenar();
                best = pob.mI;
            }
            else
            {
                generaciones[gene - 1].ordenar();
                for (int i = 0; i < 100; i++)
                {
                    pob.listaindividuos.Add(generaciones[(gene - 1)].listaindividuos[i]);
                }
                generaciones.Add(pob);
            }
        }

        public Individuo Generar()
        {
            do
            {
                GenerarPob();
                generaciones[gene].Mutar();
                generaciones[gene].ordenar();
                generaciones[gene].Cruzar(Elitismo(r), Elitismo(r));
                generaciones[gene].ordenar();
                if (generaciones[gene].mI.Variabilidad() > best.Variabilidad())
                {
                    best = generaciones[gene].mI;
                }
                gene++;
                Console.WriteLine(" ");
                Console.Write("Generacion: " + gene.ToString() + "  Mejor individuo: ");
                for (int i = 0; i < 30; i++)
                    Console.Write(best.c[i].ToString() + ",");
            } while (Stop() == false);
            return best;
        }


    }
}
