using Microsoft.EntityFrameworkCore;

namespace teste2.Data
{
    public class teste2DbContext : DbContext {
        public teste2DbContext(DbContextOptions<teste2DbContext> options) : base(options) { }

        public DbSet<teste2.Models.Candidato> Candidato { get; set; }
        public DbSet<teste2.Models.Curso> Curso { get; set; }

    }
}