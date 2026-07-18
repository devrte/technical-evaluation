using Microsoft.EntityFrameworkCore;
using BibliotecaLocacao.Models;

namespace BibliotecaLocacao.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; } = null!;
        public DbSet<Livro> Livros { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Locacao> Locacoes { get; set; } = null!;
    }
}