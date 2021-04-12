using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_de_produtos.Entities
{
    class Produto_Usado : Produto
    {
        public DateTime Data_Fabricacao { get; set; }
        public Produto Produto { get; set; }

        public Produto_Usado()
        {

        }

        public Produto_Usado(DateTime data_Fabricacao)
        {
            Data_Fabricacao = data_Fabricacao;
        }

        public Produto_Usado(DateTime data_Fabricacao, string nome_Produto, double preco_Produto)
        {
            Data_Fabricacao = data_Fabricacao;
            Produto.AddProduto(nome_Produto, preco_Produto);
        }

        public override string Etiqueta_Produto()
        {
            return Produto.Nome
                + " (Usado) $ "
                + Produto.Preco
                + " (Data de Fabricação : "
                + Data_Fabricacao.ToString("dd/MM/yyyy")
                + ")";

        }

      
    }
}
