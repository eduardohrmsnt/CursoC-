using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for(int i = 0; i< x; i++)
            {
                int add = int.Parse(Console.ReadLine());
                A.Add(add);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 0; i < y; i++)
            {
                int add = int.Parse(Console.ReadLine());
                B.Add(add);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 0; i < z; i++)
            {
                int add = int.Parse(Console.ReadLine());
                C.Add(add);
            }

            HashSet<int> temp = new HashSet<int>();
            temp.UnionWith(A);
            temp.UnionWith(B);
            temp.UnionWith(C);

            Console.WriteLine("Total de alunos: " + temp.Count);
        }
    }
}
