using ExemploEntityFramework.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ExemploEntityFramework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                    : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }            

    }

}