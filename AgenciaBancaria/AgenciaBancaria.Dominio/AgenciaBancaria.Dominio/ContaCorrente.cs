using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        //construtor de cliente - base: classe mae(construtor da classe base)
        public ContaCorrente (Cliente cliente, decimal lis) : base(cliente)
        {
            ValorManutencao = 0.05M;
            LIS = lis;
        }

        public decimal LIS { get; private set; }

        public decimal ValorManutencao { get; private set; }
    }
}
