using System;
using System.Collections.Generic;

namespace ProvaVendaseComissoes
{

    public class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;



        public Produto()
        {
           
        }
    }
    public class Vendedor
    {
        public string nome;
        public double comissao;

      
        public Vendedor() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<Produto> produtos = new List<Produto>();

            Produto produto = new Produto();

            Vendedor vendedor = new Vendedor();


         

             Console.Write("Informe a quantidade de itens que voce vendeu neste mes:  ");
             int quantidadeVendas = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite o nome do Vendedor:  ");
                vendedor.nome = Console.ReadLine().TrimStart().ToUpper();
                Console.Write("Informe o nome do produto: ");
                produto.nome = Console.ReadLine().TrimStart().ToUpper();
                Console.Write("Informe o valor do produto R$: ");
                produto.valor = double.Parse(Console.ReadLine());
                


                quantidadeVendas--;

                produtos.Add(produto);
               

                   
              

                double totalVendas = 0;
                foreach (Produto prod in produtos)
                {
                    totalVendas += prod.valor;
                 
                    if (produtos.Count <= 5)
                    {
                        vendedor.comissao = totalVendas * 0.4 / 100;

                    }
                    else if (produtos.Count >= 6 && produtos.Count <= 10)
                    {
                        vendedor.comissao = totalVendas * 1.3 / 100;

                    }
                    else if (produtos.Count > 10 && produtos.Count <= 15)
                    {
                        vendedor.comissao = totalVendas * 3 / 100;

                    }
                    else if (produtos.Count >= 16)
                    {
                        vendedor.comissao = totalVendas * 5 / 100;

                    }

                }

               


            } while (quantidadeVendas > 0);

            Console.WriteLine($"A comissâo do vendedor {vendedor.nome} foi de R${vendedor.comissao}");
         
        }
    }
}
