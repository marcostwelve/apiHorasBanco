using Microsoft.EntityFrameworkCore;
using RegistroDePontos.Models;

namespace RegistroDePontos.DataContext
{
    public class RegistroPontoContext : DbContext
    {
        public RegistroPontoContext(DbContextOptions<RegistroPontoContext> options) : base(options)
        {

        }

        public DbSet<RegistroPonto> Registros { get; set; }
    }
}
