using aec_webapi_entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace aec_webapi_entity_framework.Servicos
{
  public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    public DbSet<Usuario> Carros { get; set; }
    public DbSet<Vagas> Marcas { get; set; }
  }
}