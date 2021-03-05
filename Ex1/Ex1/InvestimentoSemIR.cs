using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class InvestimentoSemIR : Investimento
    {
        public double CalcularLucroSemIR(int meses)
        {
            if (valorInicial > 1000)
            {
                throw new Exception("O valor inicial não pode ser menor que R$1000");
            }
            else if (valorInicial <= 1000)
            {
                double valorJuros = Math.Pow((1 + jurosMensais), meses);
                mesesVariavelTransitoria = meses;

                return Math.Round(((valorInicial * valorJuros) - valorInicial), 2);
            }

            return 0;
        }
    }
}

