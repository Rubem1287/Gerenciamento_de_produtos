using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Gerenciamento_de_produtos.Entities
{
    class Produto_Importado : Produto
    {
        public double Taxa_Alfandega { get; set; }
        public Produto_Importado()
        {

        }

        public Produto_Importado(double taxa)
        {
            Taxa_Alfandega = taxa;
        }
        public Produto_Importado(string produto_Nome, double preco_Produto, double taxa)
        {
            Taxa_Alfandega = taxa;
            Nome = produto_Nome;
            Preco = preco_Produto;
            
        }

        public override string Etiqueta_Produto()
        {

            return Nome
                + " $ "
                + Preco_Total().ToString("F2", CultureInfo.InvariantCulture)
                + " (Custos Adicionais : "
              + Taxa_Alfandega
              + ")";
        }

        public double Preco_Total()
        {
            

            double s = 0;

            s += Taxa_Alfandega + Preco;
            return s;
        }






    }
}
