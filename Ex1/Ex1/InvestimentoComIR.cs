using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class InvestimentoComIR : Investimento
    {
        public double CalcularLucroComIR(int meses)
        {
            if (meses < 6)
            {
                double valorJuros = Math.Pow((1 + jurosMensais), meses);
                mesesVariavelTransitoria = meses;

                return (Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) - ((Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) * 0.225) ;
            } 
            else if (meses < 12 )
            {
                double valorJuros = Math.Pow((1 + jurosMensais), meses);
                mesesVariavelTransitoria = meses;

                return (Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) - ((Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) * 0.20);
            }
            else if (meses < 24)
            {
                double valorJuros = Math.Pow((1 + jurosMensais), meses);
                mesesVariavelTransitoria = meses;

                return (Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) - ((Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) * 0.175);
            }
            else if (meses >= 24)
            {
                double valorJuros = Math.Pow((1 + jurosMensais), meses);
                mesesVariavelTransitoria = meses;

                return (Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) - ((Math.Round(((valorInicial * valorJuros) - valorInicial), 2)) * 0.15);
            }
            return 0;
        }
    }
}
