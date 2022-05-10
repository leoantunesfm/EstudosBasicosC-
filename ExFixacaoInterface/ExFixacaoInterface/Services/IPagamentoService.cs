using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacaoInterface.Services
{
    interface IPagamentoService
    {
        public double Juros(double valor, int meses);

        public double Taxa(double valor);
    }
}
