using System;
using System.Collections.Generic;
using ExemploComposicao.Entities.Enums;

namespace ExemploComposicao.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelSenioridade Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contrato> Contratos { get; set; } = new List<Contrato>();

        public Trabalhador() { }

        public Trabalhador(string nome, NivelSenioridade nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato (Contrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(Contrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double TotalRecebido(int ano, int mes)
        {
            double soma = SalarioBase;

            foreach(Contrato contrato in Contratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }

            return soma;
        }
    }
}
