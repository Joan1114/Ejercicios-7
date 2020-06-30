using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ene = 1, Feb = 2, Marzo = 3;
            int Abril = 4, May = 5, Jun = 6, Jul = 7;
            int Agosto = 8, Sept = 9, Octu = 10;
            int Nov = 11, Dic = 12;
            int seleccion;
            string r = "";

            while (r.ToUpper() != "N")
            {
                Console.WriteLine("Escoga un mes del año 1-12");
                seleccion = int.Parse(Console.ReadLine());

                if (seleccion == 1)
                {
                    int diasenEne = System.DateTime.DaysInMonth(2019, Ene);
                    Console.WriteLine("En enero hay " + diasenEne + " dias\n");
                } if (seleccion == 2)
                {
                    int diasenFeb = System.DateTime.DaysInMonth(2019, Feb);
                    Console.WriteLine("En Febrero hay " + diasenFeb + " dias\n");
                } if (seleccion == 3)
                {
                    int diasenMarzo = System.DateTime.DaysInMonth(2019, Marzo);
                    Console.WriteLine("En Marzo hay " + diasenMarzo + " dias\n");
                } if (seleccion == 4)
                {
                    int diasenAbril = System.DateTime.DaysInMonth(2019, Abril);
                    Console.WriteLine("En Abril hay " + diasenAbril + " dias\n");
                } if (seleccion == 5)
                {
                    int diasenMayo = System.DateTime.DaysInMonth(2019, May);
                    Console.WriteLine("En Mayo hay " + diasenMayo + " dias\n");
                } if (seleccion == 6)
                {
                    int diasenJunio = System.DateTime.DaysInMonth(2019, Jun);
                    Console.WriteLine("En Junio hay " + diasenJunio + " dias\n");
                } if (seleccion == 7)
                {
                    int diasenJulio = System.DateTime.DaysInMonth(2019, Jul);
                    Console.WriteLine("En Julio hay " + diasenJulio + " dias\n");
                } if (seleccion == 8)
                {
                    int diasenAgosto = System.DateTime.DaysInMonth(2019, Agosto);
                    Console.WriteLine("En Agosto hay " + diasenAgosto + " dias\n");
                } if (seleccion == 9)
                {
                    int diasenSept = System.DateTime.DaysInMonth(2019, Sept);
                    Console.WriteLine("En Septiembre hay " + diasenSept + " dias\n");
                } if (seleccion == 10)
                {
                    int diasenOctu = System.DateTime.DaysInMonth(2019, Octu);
                    Console.WriteLine("En Octubre hay " + diasenOctu + " dias\n");
                } if (seleccion == 11)
                {
                    int diasenNov = System.DateTime.DaysInMonth(2019, Nov);
                    Console.WriteLine("En Noviembre hay " + diasenNov + " dias\n");
                } if (seleccion == 12)
                {
                    int diasenDic = System.DateTime.DaysInMonth(2019, Dic);
                    Console.WriteLine("En Diciembre hay " + diasenDic + " dias\n");
                }
                Console.WriteLine("\n¿Quieres revisar otro mes? Pulse: S para cerrar Pulse: N");
                r = Console.ReadLine();
            }
           

            
        }
    }
}
