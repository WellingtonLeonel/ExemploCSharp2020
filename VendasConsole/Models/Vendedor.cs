using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Models
{
    class Vendedor
    {
        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }
        public string Nome { get; set; }
        public string cpf { get; set; }
        public DateTime CriadoEm { get; set; }
        public override string ToString()
        {
            return $"Nome:{Nome} | CPF:{cpf} | Criado em:{CriadoEm}";
        }
    }
}
