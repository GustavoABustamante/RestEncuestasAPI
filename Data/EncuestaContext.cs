using Microsoft.EntityFrameworkCore;
using RestEncuestasAPI.Data.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RestEncuestasAPI.Data
{
    public class EncuestaContext : DbContext
    {
        public DbSet<Encuesta> Encuestas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "EncuestasDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region EncuestaSeed
            var encuesta1 = new Encuesta
            {
                Id = "1",
                Nombre = "Encuesta 1",
                TipoEncuesta = "Matematicas"
            };
            var encuesta2 = new Encuesta
            {
                Id = "2",
                Nombre = "Encuesta 2",
                TipoEncuesta = "Ciencias"
            };
            var encuesta3 = new Encuesta
            {
                Id = "3",
                Nombre = "Encuesta 3",
                TipoEncuesta = "Religion"
            };
            var encuesta4 = new Encuesta
            {
                Id = "4",
                Nombre = "Encuesta 4",
                TipoEncuesta = "Lenguaje"
            };
            var encuesta5 = new Encuesta
            {
                Id = "5",
                Nombre = "Encuesta 5",
                TipoEncuesta = "Historia"
            };
            var encuesta6 = new Encuesta
            {
                Id = "6",
                Nombre = "Encuesta 6",
                TipoEncuesta = "Historia"
            };
            var encuesta7 = new Encuesta
            {
                Id = "7",
                Nombre = "Encuesta 7",
                TipoEncuesta = "Historia"
            };
            var encuesta8 = new Encuesta
            {
                Id = "8",
                Nombre = "Encuesta 8",
                TipoEncuesta = "Historia"
            };
            var encuesta9 = new Encuesta
            {
                Id = "9",
                Nombre = "Encuesta 9",
                TipoEncuesta = "Historia"
            };
            var encuesta10 = new Encuesta
            {
                Id = "10",
                Nombre = "Encuesta 10",
                TipoEncuesta = "Historia"
            };
            var encuesta11 = new Encuesta
            {
                Id = "11",
                Nombre = "Encuesta 11",
                TipoEncuesta = "Historia"
            };

            modelBuilder.Entity<Encuesta>().HasData(new List<Encuesta> { encuesta1, encuesta2, encuesta3, encuesta4, encuesta5, encuesta6, encuesta7, encuesta8, encuesta9, encuesta10, encuesta11 });
            #endregion
        }
    }
}
