using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaBDCliente
{
    internal class Pessoa
    {
        // Atributos privados
        private string nome;
        private string cpf;
        private double salario;

        // Propriedades públicas
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public double Salario { get => salario; set => salario = value; }

        // Construtor
        public Pessoa(string _nome, string _cpf, double _salario)
        {
            this.Nome = _nome;
            this.Cpf = _cpf;
            this.Salario = _salario;
        }

        public double calcCredito()
        {
            // Sua lógica de cálculo aqui
            return 1000.0; // Exemplo
        }
    }
}
