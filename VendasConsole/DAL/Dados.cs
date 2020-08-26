using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Wellington Leonel",
                cpf = "05327529967"
            };
            ClienteDAO.Cadastrar(cliente);
            Vendedor vendedor = new Vendedor
            {
                Nome = "Dave Grohl",
                cpf = "05336487967"
            };
            VendedorDAO.Cadastrar(vendedor);
            Produto produto = new Produto
            {
                Nome = "Macarrão",
                Preco = 3.00,
                Quantidade = 10
            };
            ProdutoDAO.Cadastrar(produto);
        }
    }
}