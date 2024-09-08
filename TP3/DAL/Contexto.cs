using Microsoft.EntityFrameworkCore;
using TP3.Models;

namespace TP3.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
