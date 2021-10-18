using Mvc.Dapper.Entity.Data.Mappings.EntityFramework;
using Mvc.Dapper.Entity.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mvc.Dapper.Entity.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) =>
            Database.EnsureCreated();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new AutorMap());
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
    }
}