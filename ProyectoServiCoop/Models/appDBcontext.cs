using Microsoft.EntityFrameworkCore;
using ProyectoServiCoop.Models;
using ProyectoServiCoop.Models1;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProyectoServiCoop.Models
{
    public class appDBcontext : DbContext
    {
        public appDBcontext(DbContextOptions<appDBcontext> options): base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ProyectoCoop2022;Trusted_Connection=True;MultipleActiveResultSets=True");
        //}
        public DbSet<Servi> servi { get; set; }
        public DbSet<Controle> controle { get; set; }
    }
}

    
    





