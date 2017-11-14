using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTowns
{
    class Program
    {
        static void Main(string[] args)
        {
            string city1 = "";
            string city2 = "";
            city1 = Console.ReadLine();
            city2 = Console.ReadLine();

            string[] arrOfCities = new string[2];
            arrOfCities[0] = city1;
            arrOfCities[1] = city2;

            do
            {

                if (city1[city1.Length - 1] == city2[0])
                {
                    city1 = city2;
                    city2 = Console.ReadLine();
                }
                else
                {
                    do
                    {
                        Console.WriteLine("false.Try Again");
                        city2 = Console.ReadLine();
                    }
                    while (city2[0] != city1[city1.Length - 1]);
                }
                Array.Resize(ref arrOfCities, arrOfCities.Length + 1);
                arrOfCities[arrOfCities.Length - 1] = city2;

            } while (city1 != "stop" && city2 != "stop");

            Console.WriteLine("=============Finall============");

            for (int i = 0; i < arrOfCities.Length; i++)
            {
                Console.WriteLine("The cities which were used");
                Console.WriteLine(arrOfCities[i]);
            }
        }
    }
}
