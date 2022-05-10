using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacaoInterface.Services
{
    class PayPalService : IPagamentoService
    {
        public double Juros(double valor, int meses)
        {
            return (valor * 0.01) * meses;
        }

        public double Taxa(double valor)
        {
            return valor * 0.02;
        }
    }
}
