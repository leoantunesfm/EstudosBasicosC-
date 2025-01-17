﻿using System;
using System.Collections.Generic;
using Ex_Polimorfismo.Entities;

namespace Ex_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            List<Produto> produtos = new List<Produto>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do {i}º produto: ");
                Console.Write("Comum, usado ou importado (c/u/i)?");
                char tipoProduto = char.Parse(Console.ReadLine());

                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                switch (tipoProduto)
                {
                    case 'c':
                        produtos.Add(new Produto(nome, preco));

                        break;
                    case 'u': 
                        Console.Write("Data de fabricação (DD/MM/YYYY): ");
                        DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                        produtos.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                        break;
                    case 'i': 
                        Console.Write("Taxa de importação: ");
                        double taxaImportacao = double.Parse(Console.ReadLine());
                        produtos.Add(new ProdutoImportado(nome, preco, taxaImportacao));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiquetas de preço: ");

            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.EtiquetaPreco());
            }
        }
    }
}
