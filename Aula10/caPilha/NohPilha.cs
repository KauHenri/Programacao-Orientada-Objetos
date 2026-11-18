using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilha
{
    internal class NohPilha
    {
        private char dado;
        private NohPilha prox;

        //construtores
        public NohPilha()
        {
            dado = ' ';
            prox = null;
        }
        public NohPilha(char _dado)
        {
            dado = _dado;
            prox = null;
        }
        public NohPilha(char _dado, NohPilha _prox)
        {
            dado = _dado;
            prox = _prox;
        }

        public char Dado { get => dado; set => dado = value; }
        internal NohPilha Prox { get => prox; set => prox = value; }
    }
}
