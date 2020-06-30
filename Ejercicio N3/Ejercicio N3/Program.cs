using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

                Console.WriteLine("Los dias de la semana son: ");
           
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
                
            } Console.ReadKey();
        }

    }
}
