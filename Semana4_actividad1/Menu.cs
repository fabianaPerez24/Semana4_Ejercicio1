using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_actividad1
{
    internal class Menu
    {
        int n;
        public void SetANumber()
        {
            Console.WriteLine("Inserta un numero");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("El fibonacci del numero es:");
            Fibonacci();
            Console.WriteLine("El primo del numero es:");
            Primos();
            //Console.WriteLine("Su numero perfecto es");
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
            int m = 2;

            if ((n % m) == 0)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }

        }
        //public void NumeroPerfecto()

    }

    
}
