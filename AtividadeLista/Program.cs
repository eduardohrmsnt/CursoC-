using System;
using System.Collections.Generic;
using System.Globalization;

namespace AtividadeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> list = new List<Empregado>();
            Console.WriteLine("How many employees will be regitered?");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i<=qtd; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregado(id, nome, salario));
                

            }


            Console.WriteLine();
            Console.WriteLine("Enter the employee id that you will have salary increase: ");
            int func = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == func);

            if(emp != null)
            {
                Console.WriteLine("Entre the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(percentage);
            }
            else
            {
                Console.WriteLine("Employee doesn't exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");

            foreach(Empregado obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
