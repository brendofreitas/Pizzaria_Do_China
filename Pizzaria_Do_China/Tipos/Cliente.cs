using Pizzaria_Do_China.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_Do_China.Tipos
{
    public class Cliente : Venda 
    {
        private int CPF { get; set; }
        private string Nome { get; set; }
        public Cliente(int id, double valor, EProdutos TiposDeProdutos, int cpf, string nome) : base(id, valor, TiposDeProdutos)
        {
            CPF = cpf;
            Nome = nome;
        }

       

        




}
}
