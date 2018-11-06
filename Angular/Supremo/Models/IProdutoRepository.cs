using System.Collections.Generic;

namespace Supremo.Models
{
    public interface IProdutoRepository
    {
        List<Produto> ListarProdutos();
        Produto ObterProdutoPorId(int id);
    }
}