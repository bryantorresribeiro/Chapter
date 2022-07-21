using Chapter.WebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace Chapter.WebApi.Contexts
{
    
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options)
        : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-DPJRN7U2\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            }
        }
       
        public DbSet<Livro> Livros { get; set; }
        }
}