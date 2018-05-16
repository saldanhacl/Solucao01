using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagrado
{
    class User
    {

        public string nome;
        public string cpf;

        public User(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public override string ToString()
        {
            return nome + " | CPF: " + cpf;
        }

    }
}
