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
            Funcionario Brendo = new Funcionario("Brendo", 12872266712, 3000);


            

            List<Venda> vendas = new List<Venda>();

            
            vendas.Add(new Venda(01, 20, (EProdutos)2));
            vendas.Add(new Venda(02, 30.24, (EProdutos)1));


            Console.WriteLine();
            foreach (Venda item in vendas)
            {
                Console.WriteLine(item);
               
                
            }

            var total = new Venda();
            total.ValorTotal(vendas);




           

            
        }
    }
}
