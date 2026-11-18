using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p1 = new Pilha();
            p1.insere('{');
            p1.insere('[');
            p1.insere('(');

            p1.imprime();

            Console.ReadLine();
        }
    }
}
