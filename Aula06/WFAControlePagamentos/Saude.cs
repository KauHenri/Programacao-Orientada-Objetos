using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAControlePagamentos
{
    internal class Saude : Pagtos
    {
        private string estabelecimento;
        private double vlfatSaude;

        public override void faturar()
        {
            this.vlfatSaude = this.valor * 1.12;
        }

        public string getEstabelecimento()
        {
            return estabelecimento;
        }
        public void setEstabelecimento(string e)
        {
            this.estabelecimento = e;
        }

        public double getVlfatSaude() {
            return vlfatSaude;
        }

    }
}
