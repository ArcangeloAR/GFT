using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Investimento
    {
        public double valorInicial;
        public double jurosMensais;
        public int mesesVariavelTransitoria;


        public double CalcularLucro(int meses)
        {
            double valorJuros = Math.Pow((1 + jurosMensais), meses);
            mesesVariavelTransitoria = meses;

            return Math.Round( ((valorInicial * valorJuros) - valorInicial), 2);
            
        }


    }
}
