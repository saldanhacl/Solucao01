using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagrado
{
    class Produto
    {
        public long idProduto;
        public String nome;
        public Double preco;
        public int quantidade;

        public Produto(String nome, Double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = 0;

    }

    public Produto(long idProduto, String nome, Double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.idProduto = idProduto;
            this.quantidade = 0;

        }

        public override string ToString() {
            return nome + "        |        R$" + preco.ToString();
        }


    }
}
