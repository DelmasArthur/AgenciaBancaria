using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaPoupanca : ContaBancaria
    {
        //construtor de cliente - base: classe mae(construtor da classe base)
        public ContaPoupanca(Cliente cliente): base(cliente)
        {
            //M - valor decimal 0.003M = 0,3%
            PercentualRendimento = 0.003M;
        }

        public decimal PercentualRendimento { get; private set; }

    }
}
