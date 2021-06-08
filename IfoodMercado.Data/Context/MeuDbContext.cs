using IfoodMercado.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace IfoodMercado.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) 
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

    }
}
