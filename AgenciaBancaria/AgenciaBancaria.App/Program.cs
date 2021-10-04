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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
