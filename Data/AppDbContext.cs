using Inhouse.Models;
using Microsoft.EntityFrameworkCore;

namespace Inhouse.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Jogador> Jogadores {  get; set; }

    }
}
