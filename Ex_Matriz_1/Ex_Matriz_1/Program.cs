using System;

namespace Ex_Matriz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                 
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Main diagonal:");

            for(int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }

            Console.WriteLine();

            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        contador++;
                    }
                }
            }

            Console.Write("Negative numbers: " + contador);
        }
    }
}
