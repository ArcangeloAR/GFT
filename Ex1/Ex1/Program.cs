using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            InvestimentoComIR investComIR = new InvestimentoComIR();
            investComIR.valorInicial = 5000;
            investComIR.jurosMensais = 0.012;
            investComIR.CalcularLucroComIR(17);

            Console.WriteLine(investComIR.CalcularLucroComIR(17));

            InvestimentoSemIR investSemIR = new InvestimentoSemIR();
            investSemIR.valorInicial = 500;
            investSemIR.jurosMensais = 0.07;
            investSemIR.CalcularLucroSemIR(10);

            Console.WriteLine(investSemIR.CalcularLucroSemIR(10));

        }
    }
}
