using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagrado
{
    class Produto
    {

        public String nome;
        public Double preco;

        public Produto(String nome, Double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString() {
            return nome + "        |        R$" + preco.ToString();
        }


    }
}
