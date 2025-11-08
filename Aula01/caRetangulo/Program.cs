using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(); // cria o objeto r1 da classe Retangulo

            r1.Comprimento = 5.0;
            r1.setComprimento(5.0);
            r1.Altura = 3.0;
            r1.setAltura(3.0);

            Console.WriteLine("Area do r1: " + r1.Area());
            Console.ReadLine();

            Console.WriteLine("Perimetro do r1: " + r1.Perimetro());
            Console.ReadLine();

        }
    }
}
