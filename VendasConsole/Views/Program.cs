using System;
using System.Collections.Generic;
using VendasConsole.Models;
using System.Diagnostics;
using System.Runtime.Serialization;
using VendasConsole.DAL;

namespace VendasConsole.Views
{
    class Program
    {
        //https://www.geradorcpf.com/algoritmo_do_cpf.htm
        static void Main(string[] args)
	{
            int opcao;
            
            do
	        {
             Console.Clear();
             Console.WriteLine("------ Menu ------");
             Console.WriteLine("\n1 - Cadastrar cliente");
             Console.WriteLine("2 - Listar cliente");
             Console.WriteLine("0 - Sair");
             Console.WriteLine("\nDigite a opção desejada");
             opcao = Convert.ToInt32(Console.ReadLine());
             Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();             
                        break; 

                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("****** Opção inválida!!! ******");
                        break;
                }
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 0);
        }
    }
}
