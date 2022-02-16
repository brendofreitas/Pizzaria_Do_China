using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_Do_China.funcionarios
{
    public class Funcionario
    {
        private string Nome;
        private long Cpf;
        private double Salario;
       

      

        public Funcionario (string nome, long cpf, double salario)
        {
            Nome = nome;
            Cpf= cpf;
            Salario = salario;

        }

         virtual public double bonificacao(double Salario)
        {
            double bonificacao = Salario * 0.2;
            return bonificacao;

        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", CPF: " + Cpf + ", Salario: " + Salario;
        }

    }
}
