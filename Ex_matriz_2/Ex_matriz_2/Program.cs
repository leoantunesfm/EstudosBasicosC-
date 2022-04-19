using System;

namespace Ex_matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tamanhoMatriz = Console.ReadLine().Split(" ");
            int m = int.Parse(tamanhoMatriz[0]);
            int n = int.Parse(tamanhoMatriz[1]);

            int[,] matriz = new int[m,n];

            for(int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(" ");

                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int valorProcurado = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == valorProcurado)
                    {
                        Console.WriteLine("Posição {0}, {1}: ", i, j);

                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
