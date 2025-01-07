using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjemploApp.Modelos;

    public class EjemploAppDbContext : DbContext
    {
        public EjemploAppDbContext (DbContextOptions<EjemploAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<EjemploApp.Modelos.Autor> Autores { get; set; } = default!;

        public DbSet<EjemploApp.Modelos.Libro> Libros { get; set; } = default!;
    }
