using System;
using AluguelDeCarros.Entities;

namespace AluguelDeCarros.Services
{
    class AluguelService
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private IImpostoService _impostoService;
        public AluguelService() { }

        public AluguelService(double precoPorHora, double precoPorDia, IImpostoService impostoService)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _impostoService = impostoService;
        }

        public void ProcessaInvoice(AluguelVeiculo aluguelVeiculo)
        {
            TimeSpan duracao = aluguelVeiculo.Fim.Subtract(aluguelVeiculo.Inicio);
            double valorLiquido = 0.0;

            if(duracao.TotalHours <= 12.0)
            {
                valorLiquido = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                valorLiquido = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _impostoService.Imposto(valorLiquido);

            aluguelVeiculo.Invoice = new Invoice(valorLiquido, imposto);
        }

    }
}
