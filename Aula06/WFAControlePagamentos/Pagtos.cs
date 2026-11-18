using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAControlePagamentos
{
    internal class Pagtos
    {
        protected long cpf;
        protected double valor;
        protected int cod;

        public virtual void faturar() { }

        public long getCpf()
        {
            return cpf;
        }
        public void setCpf(long cpf)
        {
            this.cpf = cpf;
        }

        public double getValor()
        {
            return valor;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public int getCod()
        {
            return cod;
        }
        public void setCod(int cod)
        {
            this.cod = cod;
        }

    }
}
