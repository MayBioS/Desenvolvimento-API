using Api.Models;
using Microsoft.EntityFrameworkCore;
namespace Api.Contexts{

    public class ChapterContext : DbContext
    {
        public ChapterContext(){
        }

        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options){
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("DataSource=DESKTOP-IA6OFRA\\MSSQLSERVER; initial catalog=Chapter; Integrated Security=true");
            }
        }
        
        public DbSet<Livro> Livro { get; set; }
    }
}