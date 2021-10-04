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

                ContaBancaria conta = new ContaBancaria(cliente);
                Console.WriteLine("Conta criada: " + conta.NumeroConta + "-" + conta.DigitoVerificador + "  / Situacao:" + conta.Situacao );

                conta.Abrir("abcd1234");

                Console.WriteLine("Conta criada: " + conta.NumeroConta + "-" + conta.DigitoVerificador + "  / Situacao:" + conta.Situacao);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
