using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supremo.Models
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContext _myWebAppContext;

        public ProdutoRepository(MyWebAppContext myWebAppContext)
        {
            _myWebAppContext = myWebAppContext;
        }

        public List<Produto> ListarProdutos()
        {
            return _myWebAppContext.Produtos.ToList();
        }

        public Produto ObterProdutoPorId(int id)
        {
            return _myWebAppContext.Produtos.FirstOrDefault(p => p.Id ==id);
        }
    }
}
