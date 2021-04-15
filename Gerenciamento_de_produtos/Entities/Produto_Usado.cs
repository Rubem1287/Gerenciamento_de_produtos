using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Gerenciamento_de_produtos.Entities
{
    class Produto_Usado : Produto
    {
        public DateTime Data_Fabricacao { get; set; }
        

        public Produto_Usado()
        {

        }

        public Produto_Usado(DateTime data_Fabricacao)
        {
            Data_Fabricacao = data_Fabricacao;
        }

        public Produto_Usado(string nome_Produto, double preco_Produto, DateTime data_Fabricacao)
        {
            Data_Fabricacao = data_Fabricacao;
            Nome = nome_Produto;
            Preco = preco_Produto;
        }



        public override string Etiqueta_Produto()
        {
            return Nome
                + " (Usado) $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de Fabricação : "
                + Data_Fabricacao.ToString("dd/MM/yyyy")
                + ")";

        }

      
    }
}
