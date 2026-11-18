using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAEmpregadoCLT
{
    internal class EmpregadoHorista : Empregado
    {
        private int numeroHoras;
        private double precoHora;

        public EmpregadoHorista(string _primeiroNome, string _segundoNome, string _cpf, int _numeroHoras, double _precoHora)
        : base(_primeiroNome, _segundoNome, _cpf)
            {
                numeroHoras = _numeroHoras;
                precoHora = _precoHora;
            }
    }
}
