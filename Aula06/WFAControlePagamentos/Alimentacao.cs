using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAControlePagamentos
{
    internal class Alimentacao : Pagtos
    {
        private string descricao;
        private double vlfatAliment;

        public override void faturar()
        {
            this.vlfatAliment = this.valor * 1.05;
        }

        public string getDescricao()
        {
            return descricao;
        }   
        public void setDescricao(string d)
        {
            this.descricao = d;
        }

        public double getVlfatAliment()
        {
            return vlfatAliment;
        }
    }
}
