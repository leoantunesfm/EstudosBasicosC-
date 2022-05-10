using System;
using ExFixacaoInterface.Entities;

namespace ExFixacaoInterface.Services
{
    class ContratoService
    {
        private IPagamentoService _pagamentoService;

        public ContratoService(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        public void ProcessaContrato(Contrato contrato, int meses)
        {
            
            double valorBase = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                double valorParcela = valorBase + _pagamentoService.Juros(valorBase, i);
                valorParcela += _pagamentoService.Taxa(valorParcela);

                DateTime dataParcela = contrato.Data.AddMonths(i);

                contrato.AddParcelas(new ContratoParcela(dataParcela, valorParcela));
                
            }
        }
    }
}
