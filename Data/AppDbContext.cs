using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace CoreBusiness.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; } // Agrega más tablas aquí
    }

}
