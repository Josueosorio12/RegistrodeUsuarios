using Microsoft.EntityFrameworkCore;
using RegistrodeUsuarios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeUsuarios.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging().UseSqlite(@"Data Source = DATA\Usuairios.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                Usuarioid = 1,
                Nombres = "Josue",
                Apellidos = "Osorio",
                NombreDeUsuario = "Josue2018",
                Contrasena = "e1ab9d7f0b137ad16566742ad38863ec42b6d7fba157ef51638e60a4e044bd13"
                //Contrasena: cortina123
            });
        }
    }
}