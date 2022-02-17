using Pizzaria_Do_China.funcionarios;
using Pizzaria_Do_China.Funcoes;
using System;
using System.Collections.Generic;
using Pizzaria_Do_China.Tipos;
using static Pizzaria_Do_China.Tipos.Produtos;

namespace Pizzaria_Do_China
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funcionario Brendo = new Funcionario("Brendo", 12872266712, 3000);
            List<Cliente> vendas = new List<Cliente>();
            vendas.Add(new Cliente(01, 20.09, (EProdutos)2,128722,"Brendo"));
            vendas.Add(new Cliente(02, 30.24, (EProdutos)1,205484,"Raphael"));

            foreach (Cliente item in vendas)
            {
                Console.WriteLine(item);
            }
            var total = new Cliente();
            total.ValorTotal(vendas);



            Console.ReadLine();

           

            
        }
    }
}
