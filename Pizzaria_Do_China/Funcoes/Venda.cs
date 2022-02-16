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
        public int VendaId { get; set; }
        public double ValorProduto { get; set; }

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

        public virtual void ValorTotal(List<Venda> venda)
        {
            double total = 0;
            foreach (Venda v in venda)
            {
                total = total + v.ValorProduto;
                Console.WriteLine(total);
            }
        }
    }

}

