using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_de_produtos.Entities
{
    class Produto_Importado : Produto
    {
        public double Taxa_Alfandega { get; set; }
        public Produto Produto { get; set; }
        public Produto_Importado()
        {

        }


        public Produto_Importado(double taxa)
        {
            Taxa_Alfandega = taxa;
        }
        public Produto_Importado(double taxa, Produto produto)
        {
            Taxa_Alfandega = taxa;
            Produto = produto;
        }

        public override string Etiqueta_Produto()
        {

            return Produto.Nome
                + " $ "
                + Preco_Total()
                + " (Custos Adicionais : "
              + Taxa_Alfandega
              + ")";
        }

        public double Preco_Total()
        {
            

            double s = 0;

            s += Taxa_Alfandega + Produto.Preco;
            return s;
        }






    }
}
