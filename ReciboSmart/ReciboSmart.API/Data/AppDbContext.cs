using Microsoft.EntityFrameworkCore;
using ReciboSmart.API.Models;

namespace ReciboSmart.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // É isto que vai dizer ao SQLite para criar uma tabela chamada "Recibos"
        public DbSet<Recibo> Recibos { get; set; }
    }
}