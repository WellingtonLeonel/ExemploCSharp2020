﻿using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine("------ Listar cliente ------");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }
            // for (int i = 0; i < clientes.Count; i++)
            // {
            //     Console.WriteLine(clientes[i]);
            // }
        }
    }
}
