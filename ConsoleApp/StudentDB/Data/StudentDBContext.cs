using Microsoft.EntityFrameworkCore;

namespace StudentDB.Models
{
    public class EstudanteContext : DbContext
    {
        public EstudanteContext (DbContextOptions<EstudanteContext> options)
            : base(options)
        {
        }

        public DbSet<Estudante> Estudante { get; set; }

        public DbSet<Faculdade> Faculdade { get; set; }
    }
}
