using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            int soma = 0;

            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if(matriz[i,j] < 0)
                    {
                        soma++;
                    }
                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Negative numberes: " + soma);
        }
    }
}