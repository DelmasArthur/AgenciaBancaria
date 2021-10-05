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

        public override void Sacar(decimal valor, string senha)
        {
            if (Senha != senha)
                throw new Exception("Senha invalida");

            if ((Saldo+LIS) < valor)
                throw new Exception("Saldo insuficiente");

            Saldo -= valor;


        }
        public decimal LIS { get; private set; }

        public decimal ValorManutencao { get; private set; }
    }
}
