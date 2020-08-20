using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models

{
    class Cliente
    {
        //Construtor
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            cpf = cpf;
   
        }
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedade e característica
       public string Nome { get; set; }
        public string cpf { get; set; }
        public DateTime CriadoEm { get; set; }
        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {cpf} | Criado em: {CriadoEm}";
        }

    }
}
 