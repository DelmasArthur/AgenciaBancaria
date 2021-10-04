﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public abstract class ContaBancaria
    {
        public ContaBancaria(Cliente cliente)
        {
            Random random = new Random();
            NumeroConta = random.Next(50000, 99999);
            DigitoVerificador = random.Next(1, 9);
            Situacao = SituacaoConta.Criada;

            Cliente = cliente ?? throw new Exception("Cliente deve ser informado");
        }

        //metodo = acao
        public void Abrir(string senha)
        {
            SetSenha(senha);
            
            Situacao = SituacaoConta.Aberta;
            DataAbertura = DateTime.Now;
        }

        //validacao tamanho da senha
        private void SetSenha(string senha)
        {
            //validacao, mas atribuindo a ela mesmo
            Senha = senha.ValidaStringVazia();

            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                throw new Exception("Senha invalida");
            }

            Senha = senha;
        }

        public void Sacar(decimal valor, string senha)
        {
            if (Senha != senha)
                throw new Exception("Senha invalida");

            if (Saldo < valor)
                throw new Exception("Saldo insuficiente");

            Saldo -= valor;


        }

        public int NumeroConta { get; init; }
        public int DigitoVerificador { get; init; }
        public decimal Saldo { get; protected set; }
        public DateTime? DataAbertura { get; private set; }
        public DateTime? DataEncerramento { get; private set; }
        public SituacaoConta Situacao { get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; init; }

    }
}
