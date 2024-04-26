using alunosapi.Models;
using Microsoft.EntityFrameworkCore;

namespace alunosapi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AlunoModel> Alunos { get; set; }
    }
}
