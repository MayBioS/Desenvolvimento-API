using API.Models;
using Microsoft.EntityFrameworksCore;

namespace API.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.isConfigured)
            {
                optionsBuilder.UseSqlServer("DataSource=DESKTOP-IA6OFRA\MSSQLSERVER; initial catalog=Livraria; Integrated Security=true");
            }
        }
        public DbSet<Livro> Livro { get; set; }
    }
}