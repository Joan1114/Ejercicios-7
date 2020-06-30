using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida al usuario 4 numeros, los memorice y calcule la media aritmetica 
            y luego muestre en pantalla la media y los datos tecleados.*/

            int valores = 4;
            int[] numeros = new int[valores];
            int media;

            for (int i = 0; i < valores; i++)
            {
                Console.WriteLine("Ingrese el digito #" + (i + 1));
                numeros[i] = int.Parse(Console.ReadLine());
            }

            media = (numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4;

            Console.WriteLine("El valor de la media es: " + media);

            Console.WriteLine("Los digitos son:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();
        }
    }
}
