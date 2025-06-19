using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ticomarkenet.Models;

namespace ticomarkenet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
    }
}
