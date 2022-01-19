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
        private int Cpf;

        public Funcionario(string nome)
        {
            Nome = nome;
        }

        public Funcionario(int cpf)
        {
            Cpf = cpf;
        }
    }
}
