using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitoEratostenesa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] arrayElements;
            int elements = 0;

            do
            {
                Console.WriteLine("Podaj ilosc elemntow aby znalezc liczby pierwsze w przediale. Liczba musi byc wieksza niz 2");
            } while (!int.TryParse(Console.ReadLine(), out elements) || elements <= 2 );

            arrayElements = new bool[elements];
            arrayElements[0] = false;
            arrayElements[1] = false;

            for (int i = 2; i < arrayElements.Length; i++)                                                  
            {
                arrayElements[i] = true;
            }

            Console.WriteLine();
            Console.WriteLine("Liczby pierwsze to: ");

            for (int i = 2; i < arrayElements.Length; i++)                                  
            {
                if (arrayElements[i] == true)
                {
                    Console.Write(i + ",");

                    for (int j = (i + i); j < arrayElements.Length; j += i)
                    {
                        arrayElements[j] = false;
                    }
                }
                else
                {
                    continue;
                }

            }
         
            Console.ReadKey();
        }
    }
}
