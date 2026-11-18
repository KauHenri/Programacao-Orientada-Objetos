using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEmpregadoCLT
{
    internal class Empregado
    {
        //Atributos
        protected string primeiroNome;
        protected string segundoNome;
        protected string cpf;

        //Getters e Setters
        public string PrimeiroNome { get => primeiroNome; set => primeiroNome = value; }
        public string SegundoNome { get => segundoNome; set => segundoNome = value; }
        public string CPF { get => cpf; set => cpf = value; }

        //Construtor
        public Empregado() 
        {
            primeiroNome = "";
            segundoNome = "";
            cpf = "";
        }
        public Empregado(string primeiroNome, string segundoNome, string cpf)
        {
            this.primeiroNome = primeiroNome;
            this.segundoNome = segundoNome;
            this.cpf = cpf;
        }

        //Metodo generico para o calculo do salario liquido
        public virtual double getSalarioLiquido()
        {
            return 0.0;
        }
    }
}
