using Pizzaria_Do_China.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_Do_China.Funcoes
{
    public class Venda : Produtos
    {
        private double valorProduto;

        public int VendaId { get; set; }
        public double ValorProduto { get => valorProduto; set => valorProduto = value; }

        public EProdutos TipoProdutos { get; set; }

        public Venda(int id, double valorProduto, EProdutos TiposDeProdutos)
        {
            VendaId = id;
            ValorProduto = valorProduto;
            TipoProdutos = TiposDeProdutos;
        }
        public Venda()
        {

        }

        public override string ToString()
        {
            return "ID: " + VendaId + " Valor: " + ValorProduto + "Tipo do Produto: " + TipoProdutos;
        }

        public virtual void ValorTotal(List<Cliente> vendas)
        {
            double total = 0;

            foreach (Cliente v in vendas)
            {
                total += v.ValorProduto;
                Console.WriteLine("Teste" + total);
            }
        }
    }

}

