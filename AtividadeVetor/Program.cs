using System;

namespace AtividadeVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Inquilino[] inq = new Inquilino[10];

            Console.WriteLine("How many rooms will be rented?");
            int inquilino = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= inquilino; i++)
            {
                Console.WriteLine("Rent #" + i);
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int sala = int.Parse(Console.ReadLine());
                Console.WriteLine();

                inq[sala] = new Inquilino { Nome = nome, Email = email };

            }

            Console.WriteLine("Busy Rooms:");

            for(int i = 0; i < 10; i++)
            {
                if(inq[i] != null)
                {
                    Console.WriteLine(i + ": " + inq[i].ToString());
                }
            }
        }
    }
}
