using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine(" ---- CADASTRAR CLIENTE ---- \n");
            Console.WriteLine("Digite o nome do cliente:");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do cliente:");
            c.cpf = Console.ReadLine();
            if (Validacao.ValidarCpf(c.cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente cadastrado com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Esse cliente já existe!!!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!!!");
            }
        }
    }
}
