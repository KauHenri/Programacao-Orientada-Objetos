using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Aluno a2 = new Aluno("Kauã Henrique", "1234XXX", 123456789);

            a1.imprimeAluno();

            a2.imprimeAluno();

            Console.ReadLine();

            Aluno a3 = new Aluno("Criando objeto pelo teclado:");
            a3.imprimeAluno();
            Console.ReadLine();
        }
    }
}
