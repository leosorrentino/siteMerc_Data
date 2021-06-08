using IfoodMercado.Business.Intefaces;
using IfoodMercado.Business.Models;
using IfoodMercado.Data.Context;

namespace IfoodMercado.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }
    
    }
}