using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            //Produto paoFrances = new Produto();
            //paoFrances.Nome = "Pão Francês";
            //paoFrances.PrecoUnitario = 0.40;
            //paoFrances.Unidade = "Unidade";
            //paoFrances.Categoria = "Padaria";

            //Compra compra = new Compra();
            //compra.Quantidade = 6;
            //compra.Produto = paoFrances;
            //compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;

            Promocao promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Pascoa Feliz";
            promocaoDePascoa.DataDeInicio = DateTime.Now;
            promocaoDePascoa.DataDeTermino = DateTime.Now.AddMonths(3);


            using (LojaContext context = new LojaContext())
            {
                //    context.Compras.Add(compra);
                //    context.SaveChanges();
            }
        }
    }
}
