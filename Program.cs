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

            using (LojaContext context = new LojaContext())
            {
                Produto produto = context.Produtos.First();
                produto.Nome = "Cassino Royale";
                
                context.Produtos.Update(produto);
                context.SaveChanges();
            }

            RecuperarProdutos();

        }

        private static void ExcluirProduto()
        {
            using(LojaContext context = new LojaContext())
            {
                IList<Produto> produtos = context.Produtos.ToList();

                foreach(var item in produtos)
                {
                    context.Produtos.Remove(item);
                }
                context.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using(var context = new LojaContext())
            {
                IList<Produto> produtos = context.Produtos.ToList();
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

            using (var context = new LojaContext())
            {
                context.Produtos.Add(p);
                context.SaveChanges();
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
