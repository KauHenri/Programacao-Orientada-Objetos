using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    internal class Pilha
    {
        private NohPilha topo;

        public Pilha() 
        {
            topo = null;
        }

        public bool estaVazia()
        {
            if(topo == null)
                return true;
            else return false;
        }

        public void insere(char campo)
        {
            NohPilha NovoNoh = new NohPilha(campo);
            // Verifica se a pilha está vazia
            if (estaVazia()) 
            { 
                topo = NovoNoh;
            }
            else // A pilha não esta vazia
            {
                NovoNoh.Prox = topo;
                topo = NovoNoh;
            }

        }

        public void imprime()
        {
            NohPilha temp = new NohPilha();
            temp = topo;

            while (temp != null)
            {
                Console.WriteLine(temp.Dado);
                temp = temp.Prox;
            }
        }

        // Construir a função remove()
    }// Fim da classe pilha
}
