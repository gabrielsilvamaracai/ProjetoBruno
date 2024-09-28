using System;
using Microsoft.EntityFrameworkCore;
using ProjetoBruno.Models;

namespace ProjetoBruno.Data;

public class ConnectionContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }

    public DbSet<Curso> Cursos { get; set; }

    public ConnectionContext(DbContextOptions<ConnectionContext> options) : base (options) {}
}
