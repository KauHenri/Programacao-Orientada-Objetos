using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    internal class Retangulo
    {
        // Atributos
        private double comprimento;
        private double altura;

        public double Comprimento { get => comprimento; set => comprimento = value; }
        public double Altura { get => altura; set => altura = value; }

        // Métodos
        public void setAltura(double _altura)
        {
            altura = _altura;
        }
        public void setComprimento(double _comprimento)
        {
            comprimento = _comprimento;
        }
        public double Area()
        {
            return (comprimento * altura);
        }
        public double Perimetro()
        {
            return 2 * (comprimento + altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(comprimento * comprimento + altura * altura);
        }
        public double getComprimento()
        {
            return comprimento;
        }
        public double getAltura()
        {
            return altura;
        }
    }
}
