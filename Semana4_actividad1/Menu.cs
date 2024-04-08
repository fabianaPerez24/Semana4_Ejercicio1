using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_actividad1
{
    internal class Menu
    {
        public void SetANumber()
        {
            Console.WriteLine("Inserta un numero");
            int n = int.Parse(Console.ReadLine());



            Console.WriteLine("El fibonacci del numero es:");
            Console.WriteLine("El primo del numero es:");
            Console.WriteLine("Su numero perfecto es");
        }


        public void Fibonacci()
        {
            int a = 0;
            int b = 1;

            int c;

            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
        }
        public void Primos()
        {

        }
        public void NumeroPerfecto()
        {

        }
    }
}
