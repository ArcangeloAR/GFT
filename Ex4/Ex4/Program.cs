using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int total = 0;

            while (total <= 157)
            {
                Console.WriteLine("Digite um número: ");
                x = Convert.ToInt32(Console.ReadLine());

                while (x < 0) {
                    Console.WriteLine("Números negativos não são permitidos");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                total += x;
            }
            Console.WriteLine($"O Somátorio foi {total}.");

        }
    }
}
