using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    internal class Vetor2D
    {
        // Atributos 
        public double x;
        public double y;

        // Metodos
        public Vetor2D() // Construtor
        {
            x = 0;
            y = 0;
        } // Ele serve para inicializar os atributos

        public Vetor2D(double a, double b) // Construtor com parametros
        {
            x = a;
            y = b;
        } // Ele serve para inicializar os atributos com valores passados

        public double Modulo()
        {
            return Math.Sqrt(x * x + y * y);
        }



    }
}
