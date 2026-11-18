using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    internal class PortoSeco
    {
        private Pilha[] locais;

        private int maxLocais = 4;
        private int maxPorPilha = 3;

        public PortoSeco()
        {
            locais = new Pilha[maxLocais];

            for (int i = 0; i < maxLocais; i++)
            {
                // 4 pilhas vazias
                locais[i] = new Pilha();
            }
        }

        public void Empilhar(string codigo)
        {
            // verifica se ja existe
            for (int i = 0; i < maxLocais; i++)
            {
                if (locais[i].contem(codigo))
                {
                    Console.WriteLine("Código invalido!");
                    return;
                }
            }

            // encontra a pilha com menos containers
            int indicePilhaMaisBaixa = -1;
            int menorQuantidade = maxPorPilha + 1;

            for (int i = 0; i < maxLocais; i++)
            {
                if (locais[i].Tamanho < menorQuantidade)
                {
                    menorQuantidade = locais[i].Tamanho;
                    indicePilhaMaisBaixa = i;
                }
            }

            // ve se ja ta tudo cheio
            if (menorQuantidade == maxPorPilha)
            {
                Console.WriteLine("Impossível empilhar!");
                return;
            }


            locais[indicePilhaMaisBaixa].insere(codigo);
            Console.WriteLine($"Container {codigo} empilhado com sucesso no local {indicePilhaMaisBaixa + 1}.");
        }

        public void Desempilhar(string codigo)
        {
            // ve se ta tudo vazio
            bool patioVazio = true;
            for (int i = 0; i < maxLocais; i++)
            {
                if (locais[i].Tamanho > 0)
                {
                    patioVazio = false;
                    break;
                }
            }

            if (patioVazio)
            {
                Console.WriteLine("Impossível desempilhar!");
                return;
            }

            // procura o codigo do container
            bool codigoExiste = false;

            for (int i = 0; i < maxLocais; i++)
            {
                if (locais[i].contem(codigo))
                {
                    codigoExiste = true;

                    // ve se o container ta no topo e remove
                    if (locais[i].espiar() == codigo)
                    {
                        locais[i].remove();
                        Console.WriteLine($"Container {codigo} desempilhado com sucesso!");
                        return;
                    }
                    else
                    { 
                        Console.WriteLine("Impossível desempilhar!");
                        return;
                    }
                }
            }

            // se nao encontrou o codigo
            if (!codigoExiste)
            {
                Console.WriteLine("Código invalido!");
            }
        }

        // Método para mostrar o mapa completo do pátio
        public void MostrarPatio()
        {
            Console.WriteLine("\n================ MAPA DO PÁTIO ================");

            for (int i = 0; i < maxLocais; i++)
            {
                Console.WriteLine($"\nLOCAL {i + 1}:");
                locais[i].imprime(); // Chama a impressão daquela pilha específica
            }

            Console.WriteLine("\n===============================================");
        }
    }// fim da classe PortoSeco
}
