using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    internal class NohPilha
    {
        private string dado;
        private NohPilha prox;

        // Construtores
        public NohPilha()
        {
            dado = "";
            prox = null;
        }
        public NohPilha(string _dado)
        {
            dado = _dado;
            prox = null;
        }
        public NohPilha(string _dado, NohPilha _prox)
        {
            dado = _dado;
            prox = _prox;
        }

        public string Dado { get => dado; set => dado = value; }
        internal NohPilha Prox { get => prox; set => prox = value; }
    }// fim da classe NohPilha
}
