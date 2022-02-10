using System;
using System.Collections.Generic;
using System.Text;

namespace Cambio
{
    class ConversorMoeda
    {
        private static double IOF = 6.0;

        private static double CalculaIOF(double valorCompra, double cotacao)
        {
            return (valorCompra * (IOF / 100.0)) * cotacao;
        }

        public static double ValorAPagar(double valorCompra, double cotacao)
        {
            return (valorCompra * cotacao) + CalculaIOF(valorCompra, cotacao);
        }
    }
}
