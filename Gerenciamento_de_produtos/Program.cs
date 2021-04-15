using System;
using System.Globalization;
using System.Collections.Generic;
using Gerenciamento_de_produtos.Entities;
namespace Gerenciamento_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Console.Write("Entre com o número de produtos : ");
            int numeroProduct = int.Parse(Console.ReadLine());

            for (int c = 1; c <= numeroProduct; c++)
            {
                Console.WriteLine($"Dados do Produto #{c} : ");
                Console.Write("Produto Comun, usado ou importado (c/u/i): ");
                char tipo_Produto = char.Parse(Console.ReadLine());

                switch (tipo_Produto)
                {
                    case 'c':
                        Console.Write("Nome : ");
                        string nome_Produto = Console.ReadLine();
                        Console.Write("Preço : ");
                        double preco_Produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        produtos.Add(new Produto(nome_Produto, preco_Produto));
                       
                        
                        break;

                    case 'u':
                        Console.Write("Nome : ");
                        string nome_Produto_Usado = Console.ReadLine();
                        Console.Write("Preço : ");
                        double preco_Produto_Usado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Data de Fabricação (DD/MM/AAAA) : ");
                        DateTime data_Fabricacao = DateTime.Parse(Console.ReadLine());

                        produtos.Add(new Produto_Usado(nome_Produto_Usado, preco_Produto_Usado, data_Fabricacao));

                       
                        
                        break;

                    case 'i':
                        Console.Write("Nome : ");
                        string nome_Produto_Importado = Console.ReadLine();
                        Console.Write("Preço : ");
                        double preco_Produto_Importado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Taxa da alfândega : ");
                        double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        produtos.Add(new Produto_Importado(nome_Produto_Importado, preco_Produto_Importado, taxa));
                        break;


                }
            }
            Console.WriteLine();
            Console.WriteLine("Preço das etiquetas");
            foreach(Produto produto in produtos)  // (Tipo variável in lista)
            {
                Console.WriteLine(produto.Etiqueta_Produto());

            }
       

        }
    }
}
