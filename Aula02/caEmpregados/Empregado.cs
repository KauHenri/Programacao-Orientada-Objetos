using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregados
{
    internal class Empregado
    {
        // Atributos
        public string nome;
        public string sobrenome;
        public decimal salario;

        // Metodos
        public Empregado() 
        {
            nome = "Sem nome";
            sobrenome = "Sem sobrenome";
            salario = 0;
        }

        public Empregado(string _nome, string _sobrenome, decimal _salario)
        {
            nome = _nome;
            sobrenome = _sobrenome;
            salario = _salario < 0 ? 0 : _salario;
        }

        public void atualizaSalario(decimal aumento)
        {
            if (aumento < 0) aumento = 0;
            salario += aumento;
        }
        public void imprimeEmpregado()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Salario: " + salario);
        }
    }
}
