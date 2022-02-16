using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_Do_China.funcionarios
{
    public class Gerente : Funcionario 
    {


        public Gerente(string nome, long cpf, double salario) : base(nome, cpf,salario)
        {

        }

        static Gerente()
        {
            
        }

        public override double bonificacao(double salario)
        {
            double bonificacao = salario * 0.5 ;
            return bonificacao;
        }
    }
}
