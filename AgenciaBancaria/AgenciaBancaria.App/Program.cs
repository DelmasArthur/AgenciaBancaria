using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(
                "Arthur", 
                "12345678900",
                "1234567",
                "Rua Teste",
                "12345678",
                "Recife",
                "PE"
                );
            
        }
    }
}
