using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empregado emp1 = new Empregado();
            Console.WriteLine("Empregado 1:");
            emp1.imprimeEmpregado();

            Empregado emp2 = new Empregado();
            emp2 = new Empregado("Kauã", "Silva", 10000);
            Console.WriteLine("\nEmpregado 2:");
            emp2.imprimeEmpregado();

            Console.Write("\nDigite o valor do aumento salarial para o empregado 2: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal aumento))
            {
                emp2.atualizaSalario(aumento);
                Console.WriteLine("\nEmpregado 2 após o aumento salarial:");
                emp2.imprimeEmpregado();
            }
            else
            {
                Console.WriteLine("Valor inválido para o aumento salarial.");
            }

        }
    }
}
