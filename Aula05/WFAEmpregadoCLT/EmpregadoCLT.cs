using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEmpregadoCLT
{
    internal class EmpregadoCLT : Empregado
    {
        //Atributos
        private double salarioMensal;

        //Construtor
        public EmpregadoCLT() : base()
        {
            salarioMensal = 0;
        }

        public EmpregadoCLT(string _primeiroNome, string _segundoNome, string _cpf, double _salarioMensal) 
            : base(_primeiroNome, _segundoNome, _cpf)
        {
            salarioMensal = _salarioMensal;
        }

        public double SalarioMensal
        {
            get => salarioMensal;
            set => salarioMensal = value;
        }

        //public override string ToString()
        //{
        //    return $"Nome: {primeiroNome} {segundoNome}\n" +
        //           $"CPF: {cpf}\n" +
        //           $"Salário Mensal: {salarioMensal:C}";
        //}
    }
}
