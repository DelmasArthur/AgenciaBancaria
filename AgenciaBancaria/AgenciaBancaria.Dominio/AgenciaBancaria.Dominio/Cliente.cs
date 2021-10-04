﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {

        public Cliente(
            string nome, 
            string cpf, 
            string rg, 
            string logradouro, 
            string cep, 
            string cidade, 
            string estado)
        {


            Nome = nome.ValidaStringVazia();
            CPF = cpf.ValidaStringVazia();
            RG = rg.ValidaStringVazia();
            Logradouro = logradouro.ValidaStringVazia();
            CEP = cep.ValidaStringVazia();
            Cidade = cidade.ValidaStringVazia();
            Estado = estado.ValidaStringVazia();
        }

       

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        //Endereço
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}
