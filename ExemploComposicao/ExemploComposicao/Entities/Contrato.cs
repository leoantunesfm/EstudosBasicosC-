using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploComposicao.Entities
{
    class Contrato
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public Contrato() { }

        public Contrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return Horas * ValorPorHora;
        }
    }
}
