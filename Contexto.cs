using System;
using Microsoft.EntityFrameworkCore;
using Registro;

public class Contexto : DbContext
{
  public DbSet<Roles> Roles { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
      optionsBuilder.UseSqlite("Data Source = Roles.db");
  }
}
