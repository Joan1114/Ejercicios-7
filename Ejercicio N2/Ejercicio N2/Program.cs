using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida al usuario 5 numeros reales y 
            luego los muestre en el orden contrario al que se introdujeron*/

            int valores = 5;
            int[] num = new int[valores];

            for (int i = 0; i < valores; i++)
            {
                Console.WriteLine("Digite el valor #" + (i + 1));
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los digitos son:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
