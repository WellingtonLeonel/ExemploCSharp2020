using System;
using System.Collections.Generic;
using VendasConsole.Models;
using System.Text;

namespace VendasConsole.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();
        public static void Cadastrar(Venda venda) => vendas.Add(venda);
        public static List<Venda> Listar() => vendas;
    }
}
