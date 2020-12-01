using System;
using System.Net;

namespace OOP
{
    class Program
    {


        
        static void Main(string[] args)
        {
            input:
            Console.WriteLine("Введите число X: ");
            string X = Console.ReadLine();
            uint N;
            if (!UInt32.TryParse(X, out N))
            {
                Console.WriteLine("Вы ввели плохое число! Попробуйте снова.");
                goto input;
            }
            else
            {
                if ((UInt32.Parse(X) < 100) || (UInt32.Parse(X) > 1000))
                {
                    Console.WriteLine("Вы ввели плохое число! Попробуйте снова.");
                    goto input;
                }
                else
                {
                    uint XP = UInt32.Parse(X);
                    for (int i = 50; i < XP + 1; i++)
                    {
                        if ((i % 7) == (i % 13))
                        {
                            Console.WriteLine("{0} {1}", i, (i % 7));
                        }
                    }

                }
            }
        }
    }
}
