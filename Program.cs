using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto03_Sanchez_Zepeda//               ALGORITMOS GENETICOS
{//Objetivo: Obtener el arreglo mas variado de numeros entre 1 y 15
    class Program
    {
        static void Main(string[] args)//El mian se encarga de generar las poblacion y mostrar el mejor individuo
        {
            Random r = new Random();
            Ciclo ci = new Ciclo(r);
            ci.Generar();//Se genera un ciclo el cual se repite hasta que se encuentre al mejor indiduo
            Console.Clear();
            Console.WriteLine("En la generación " + ci.gene + " el programa llego al mejor individuo que es: ");
            for (int i = 0; i < 30; i++)
                Console.Write(ci.best.c[i].ToString() + " ");
            //Se muestra el mejor indivuiduo mostrando en que generacion se encontró
            Console.ReadKey();

        }
    }
}
