using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_de_produtos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produto_Usado Produto_Usado { get; set; }
        public Produto_Importado Produto_Importado { get; set; }
        

        public Produto()
        {

        }

        public Produto(string nome, double preco_Produto)
        {
            Nome = nome;
            Preco = preco_Produto;
           

        }

        public Produto(string nome, double preco_Produto, Produto_Usado produto_Usado)
        {
            Nome = nome;
            Preco = preco_Produto;
            Produto_Usado = produto_Usado;

        }

        public Produto(string nome, double preco_Produto, Produto_Importado produto_Importado)
        {
            Nome = nome;
            Preco = preco_Produto;
            Produto_Importado = produto_Importado;

        }

        public void AddProduto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        
        public virtual string Etiqueta_Produto()
        {


            return Nome
                + " $ "
                + Preco;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if(Nome != null)
            {
                sb.AppendLine(Etiqueta_Produto());
            }
            

            if(Produto_Importado != null)
            {
                sb.AppendLine(Produto_Importado.Etiqueta_Produto());
            }
            
            if(Produto_Usado != null)
            {
                sb.AppendLine(Produto_Usado.Etiqueta_Produto());
            }
            

            return sb.ToString();
        }



    }
}
