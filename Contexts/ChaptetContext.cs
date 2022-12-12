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
                //altere o codigo do desktop para o do seu dispositivo
                optionsBuilder.UseSqlServer("DataSource=DESKTOP-SL507-17\MSSQLSERVER; initial catalog=Livraria; Integrated Security=true");
            }
        }
        public DbSet<Livro> Livro { get; set; }
    }
}