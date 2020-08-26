using System;
using VendasConsole.DAL;
using VendasConsole.Models;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.Views
{
    class ListarVendedors
    {
        public static void Renderizar()
        {
            Console.WriteLine(" ---- LISTAR VENDEDORES ---- \n");
            foreach (Vendedor vendedorCadastrado in VendedorDAO.Listar())
            {
                Console.WriteLine(vendedorCadastrado);
            }
        }
    }
}
