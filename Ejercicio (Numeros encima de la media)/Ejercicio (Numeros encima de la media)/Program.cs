using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio__Numeros_encima_de_la_media_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Un progrma que pida al usuario 10 numeros, calcule su media y 
             luego muestre los que estan por encima de la media*/

            int val = 10;
            int[] num = new int[val];
            int media;

            for (int i = 0; i < val; i++)
            {
                Console.WriteLine("Introduzca el valor #" + (i + 1));
                num[i] = int.Parse(Console.ReadLine());
            }

            media = (num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6] +
                num[7] + num[8] + num[9]) / 10;

            Console.Write("El valor de la media es: " + media);

            Console.WriteLine("\nLos numeros por encima de la media son:");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > media)
                {
                    Console.WriteLine(num[i]);
                }
            }

            Console.ReadKey();

            
        }
    }
}
