using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    internal class Pilha
    {
        private NohPilha topo;
        private int tamanho; 

        public Pilha()
        {
            topo = null;
            tamanho = 0;
        }

        public int Tamanho { get => tamanho; }

        public bool estaVazia()
        {
            if (topo == null)
                return true;
            else return false;
        }

        public void insere(string campo)
        {
            NohPilha NovoNoh = new NohPilha(campo);

            if (estaVazia())
            {
                topo = NovoNoh;
            }
            else
            {
                NovoNoh.Prox = topo;
                topo = NovoNoh;
            }
            tamanho++; 
        }

        public string remove()
        {
            if (estaVazia())
            {
                return null; 
            }

            string valorRemovido = topo.Dado; 
            topo = topo.Prox;                 
            tamanho--;                        

            return valorRemovido; 
        }

        public string espiar()
        {
            if (estaVazia()) return null;
            return topo.Dado;
        }

        public bool contem(string codigoBuscado)
        {
            NohPilha temp = topo; 

            while (temp != null)
            {
                if (temp.Dado == codigoBuscado)
                {
                    return true; 
                }
                temp = temp.Prox; 
            }
            return false; 
        }

        public void imprime()
        {
            NohPilha temp = topo;

            if (estaVazia())
            {
                Console.WriteLine("\t[Vazio]");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine("\t[" + temp.Dado + "]");
                temp = temp.Prox;
            }
        }
    }// fim da classe Pilha
}
