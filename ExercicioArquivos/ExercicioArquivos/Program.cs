using System;
using System.IO;
using System.Collections.Generic;
using ExercicioArquivos.Entities;
using System.Globalization;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\temp\VendasAnalitico.csv";
                List<Produto> produtos = new List<Produto>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string nome = line[0];
                        double preco = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(line[2]);

                        produtos.Add(new Produto(nome, preco, quantidade));
                    }
                }

                string targetFolderPath = Path.GetDirectoryName(path) + @"\out";
                Directory.CreateDirectory(targetFolderPath);
                string targetPath = targetFolderPath + @"\VendasSintetico.csv";


                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (Produto produto in produtos)
                    {
                        sw.WriteLine(produto.Nome + ", $ " + produto.VendaTotal().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
