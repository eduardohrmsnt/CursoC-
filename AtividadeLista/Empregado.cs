using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AtividadeLista
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double perc)
        {
            Salario += (Salario * perc / 100);
        }
    }
}
