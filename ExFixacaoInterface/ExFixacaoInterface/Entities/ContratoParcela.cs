using System;

namespace ExFixacaoInterface.Entities
{
    class ContratoParcela
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public ContratoParcela()
        {
        }
        public ContratoParcela(DateTime data, double valor)
        {
            Data = data;
            Valor = valor;
        }
    }
}
