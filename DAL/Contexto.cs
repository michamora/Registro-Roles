using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using BLL;

//Contexto

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles>? Roles{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Roles.db");
        }
    }
}