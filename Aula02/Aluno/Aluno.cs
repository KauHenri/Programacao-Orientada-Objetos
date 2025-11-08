using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    internal class Aluno
    {
        // Atributos 
        public string nome;
        public string matricula;
        public int telefone;

        // Metodos
        public Aluno()
        {
            nome = string.Empty;
            matricula = string.Empty;
            telefone = 0;
        } // Construtor padrão

        public Aluno(string _nome, string _matricula, int _telefone)
        {
            nome = _nome;
            matricula = _matricula;
            telefone = _telefone;
        } // Construtor com parâmetros
        public Aluno(string teclado)
        {
            Console.WriteLine(teclado);
            Console.ReadLine();
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do aluno: ");
            matricula = Console.ReadLine();
            Console.WriteLine("Digite o telefone do aluno: ");
            telefone = Convert.ToInt32(Console.ReadLine());
        }

        public void imprimeAluno()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Matrícula: " + matricula);
            Console.WriteLine("Telefone: " + telefone);
        } // Método para imprimir os dados do aluno


    }
}
