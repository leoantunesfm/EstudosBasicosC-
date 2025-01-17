﻿using System;

namespace AluguelDeCarros.Entities
{
    class AluguelVeiculo
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Invoice Invoice { get; set; }

        public AluguelVeiculo() { }

        public AluguelVeiculo(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }
    }
}
