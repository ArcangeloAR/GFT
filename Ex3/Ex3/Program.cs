using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicando;
            int inicioDoIntervalo;
            int fimDoIntervalo;
            int numeroDoArray;


            Console.WriteLine("Multiplicando: ");
            multiplicando = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Início do intervalo: ");
            inicioDoIntervalo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fim do intervalo: ");
            fimDoIntervalo = Convert.ToInt32(Console.ReadLine());

            numeroDoArray = fimDoIntervalo - inicioDoIntervalo + 1;

            for(int i = 0; i < numeroDoArray; i++)
            {
                Console.WriteLine($"{multiplicando} x {inicioDoIntervalo + i} = {multiplicando * (inicioDoIntervalo + i)}");
            }
        }
    }
}
