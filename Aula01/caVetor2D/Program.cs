using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vetor2D v = new Vetor2D();

            v.x = 1;
            v.y = 2;

            Console.WriteLine("Vetor v: (" + v.x + ", " + v.y + ")");
            Console.WriteLine("Modulo de v: " + v.Modulo());
        }
    }
}
