using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N5__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0, m = 0, cant = 0;
            string mes1 = "";
            int[] mes = new int[12];
            mes[0] = 31;
            mes[1] = 28;
            mes[2] = 30;
            mes[3] = 31;
            mes[4] = 30;
            mes[5] = 31;
            mes[6] = 30;
            mes[7] = 31;
            mes[8] = 30;
            mes[9] = 31;
            mes[10] = 30;
            mes[11] = 31;

            Console.Write("Escriba un numero del mes: ");
            m = int.Parse(Console.ReadLine());

            switch (m)
            {
                case 1: 
                    mes1 = "Enero";
                    break;
                case 2:
                    mes1 = "Febrero";
                    break;
                case 3:
                    mes1 = "Marzo";
                    break;
                case 4:
                    mes1 = "Abril";
                    break;
                case 5:
                    mes1 = "Mayo";
                    break;
                case 6:
                    mes1 = "Junio";
                    break;
                case 7:
                    mes1 = "Julio";
                    break;
                case 8:
                    mes1 = "Agosto";
                    break;
                case 9:
                    mes1 = "Septiembre";
                    break;
                case 10:
                    mes1 = "Octubre";
                    break;
                case 11:
                    mes1 = "Noviembre";
                    break;
                case 12:
                    mes1 = "Diciembre";
                    break;
                default:
                    break;
            }
       
            for (int i = 0; i < m - 1; i++)
            {
                cant = cant + mes[i];
            }

            Console.Write("\nEscriba el numero del dia dentro del mes: ");
            d = int.Parse(Console.ReadLine());

            cant = cant + d;

            Console.WriteLine("\nEl dia " + d + " de " + mes1 + " es el dia numero " + cant + " del año");

            Console.ReadKey();
        }
    }
}
