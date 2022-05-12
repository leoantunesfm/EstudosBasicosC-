using System;
using System.Collections.Generic;
using System.IO;

namespace Exemplo_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, int> registrosVotacao = new Dictionary<string, int>();
                Console.Write("Entre com o caminho do arquivo: ");
                string path = Console.ReadLine();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidato = line[0];
                        int votos = int.Parse(line[1]);

                        if (registrosVotacao.ContainsKey(candidato))
                        {
                            registrosVotacao[candidato] += votos;
                        }
                        else
                        {
                            registrosVotacao.Add(candidato, votos);
                        }
                    }
                }

                Console.WriteLine();
                foreach (var item in registrosVotacao)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
