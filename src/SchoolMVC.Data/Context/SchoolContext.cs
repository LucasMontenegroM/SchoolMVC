using Microsoft.EntityFrameworkCore;
using SchoolMVC.Domain.Entities;


namespace SchoolMVC.Data.Context;

public class SchoolContext : DbContext
{
    public SchoolContext (DbContextOptions options) : base(options) { }
    
    public DbSet<TurmasEntity> Turmas { get; set; }
    
    public DbSet<AlunosEntity> Alunos { get; set; }
}
