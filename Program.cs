using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProduto();
            //RecuperarProdutos();
            AtualizarProduto();
        }

        private static void AtualizarProduto()
        {
            // inclui um produto
            GravarUsandoEntity();
            RecuperarProdutos();

            using (var context = new ProdutoDAOEntity())
            {
                Produto produto = context.Produtos().First();
                produto.Nome = "Cassino Royale";

                context.Atualizar(produto);
            }

            RecuperarProdutos();

        }

        private static void ExcluirProduto()
        {
            using(var context = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = context.Produtos();

                foreach(var item in produtos)
                {
                    context.Remover(item);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using(var context = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = context.Produtos();
                Console.WriteLine("Foram encontrados {0} produto(s)", produtos.Count);

                foreach(var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var context = new ProdutoDAOEntity())
            {
                context.Adicionar(p);
            }
        }

        //private static void GravarUsandoAdoNet()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.Preco = 19.89;

        //    using (var repo = new ProdutoDAO())
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
    }
}
