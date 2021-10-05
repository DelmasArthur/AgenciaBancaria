using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco(
                    "Rua Teste",
                    "12345678",
                    "Recife",
                    "PE");

                Cliente cliente = new Cliente(
                    "Arthur",
                    "12345678900",
                    "1234567",
                    endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta criada: " + conta.NumeroConta + "-" + conta.DigitoVerificador + "  / Situacao:" + conta.Situacao );

                string senha = "abcd1234";
                conta.Abrir(senha);

                Console.WriteLine("Conta criada: " + conta.NumeroConta + "-" + conta.DigitoVerificador + "  / Situacao:" + conta.Situacao);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: R$" + conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
