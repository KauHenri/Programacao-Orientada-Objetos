using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PortoSeco meuPorto = new PortoSeco();
            bool sistemaRodando = true;

            while (sistemaRodando)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("   SISTEMA DO PORTO SECO");
                Console.WriteLine("=============================");
                Console.WriteLine("1 - Empilhar Container");
                Console.WriteLine("2 - Desempilhar Container");
                Console.WriteLine("3 - Mostrar Mapa do Pátio"); // <-- Opção Nova!
                Console.WriteLine("4 - Sair do Programa");      // <-- Mudou para 4
                Console.Write("\nEscolha uma opção (1, 2, 3 ou 4): ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o CÓDIGO do container que vai ENTRAR: ");
                        string codEntrada = Console.ReadLine();
                        meuPorto.Empilhar(codEntrada);
                        break;

                    case "2":
                        Console.Write("Digite o CÓDIGO do container que vai SAIR: ");
                        string codSaida = Console.ReadLine();
                        meuPorto.Desempilhar(codSaida);
                        break;

                    case "3":
                        // <-- Nova ação no trilho!
                        meuPorto.MostrarPatio();
                        break;

                    case "4":
                        Console.WriteLine("Desligando os guindastes... Até logo!");
                        sistemaRodando = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Digite apenas de 1 a 4.");
                        break;
                }
            }
        }
    }
}
