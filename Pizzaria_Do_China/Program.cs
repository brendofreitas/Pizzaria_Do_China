using Pizzaria_Do_China.funcionarios;
using System;

namespace Pizzaria_Do_China
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.ReadLine();

            Funcionario Brendo = new Funcionario("Brendo",12872266712,3000);


            Console.WriteLine($"Executando o Nome:{Brendo.bonificacao(3000)}");

        }
    }
}
