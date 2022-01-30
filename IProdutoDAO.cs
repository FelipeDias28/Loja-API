using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    internal interface IProdutoDAO
    {
        // Essa interface contém as 4 operações do CRUD
        void Adicionar(Produto p);
        void Remover(Produto p);
        void Atualizar(Produto p);
        IList<Produto> Produtos();
    }
}
