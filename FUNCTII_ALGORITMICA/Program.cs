using System;
namespace Aplicatie_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage();

            int theFristNaber = int.Parse(Console.ReadLine());
            int theSecondNamber = int.Parse(Console.ReadLine());

            DisplayTheMinimum(theFristNaber, theSecondNamber);
        }

        static void DisplayTheMinimum(int theFristNamber, int theSecondNamber)
        {
            if (theFristNamber > theSecondNamber)
            {
                Console.WriteLine("Minimul dintre cele doua valori este : " + " " + theSecondNamber);
                Console.WriteLine("Suma dintre valorile minime obtinute este egala cu : " + MinimumAmountCalculation(theFristNamber, theSecondNamber));
            }
            else if (theSecondNamber == theFristNamber && theFristNamber == 0 && theSecondNamber == 0)
            {
                Console.WriteLine("Cele doua valori sunt egale ! Valorile trbuie sa fie diferite. EX  : 5 SI 6. Va rugam incercati sa introduce-ti valorile corespunzatoare ! ");
            }
            else
            {
                Console.WriteLine(" Minimul dintre cele doua valori este : " + " " + theFristNamber);
                Console.WriteLine("Suma dintre valorii minime obtinute este egala cu : " + MinimumAmountCalculation(theFristNamber, theSecondNamber));
            }
        }

        static int MinimumAmountCalculation(int theFristNamber, int theSecondNamber)
        {
            if (theFristNamber < theSecondNamber)
            {
                return theFristNamber + theSecondNamber;
            }
            else
            {
                return theSecondNamber + theFristNamber;
            }
        }

        static void DisplayMessage()
        {
            Console.WriteLine("Introduceti valorile dorite de la tastatura pentru a afisa minimul dintre ele ! ");
        }
    }
}
