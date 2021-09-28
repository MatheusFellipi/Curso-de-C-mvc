using Microsoft.EntityFrameworkCore;

namespace cusrso_mvc.Models
{
    public class Context : DbContext
    {
        public DbSet<CategoriasModel> Categories { get; set; }

        public DbSet<ProdutosModel> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost;Database=cursomvc;Trusted_Connection=True;");

        }
    }
}
