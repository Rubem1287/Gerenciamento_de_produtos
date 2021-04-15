using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Gerenciamento_de_produtos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
       
      
        

        public Produto()
        {

        }

        public Produto(string nome, double preco_Produto)
        {
            Nome = nome;
            Preco = preco_Produto;
           

        }


        public virtual string Etiqueta_Produto()
        {


            return Nome
                + " $ "
                + Preco.ToString("F2",CultureInfo.InvariantCulture);

        }

        
    }
}
