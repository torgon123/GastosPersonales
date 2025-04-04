using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Transacciones>? Transacciones { get; set; }
        public DbSet<Tipos_transacciones>? Tipos_transacciones { get; set; }
        public DbSet<Categorias>? Categorias { get; set; }
        public DbSet<Conversiones>? Conversiones { get; set; }
        public DbSet<Metas>? Metas { get; set; }
        public DbSet<Monedas>? Monedas { get; set; }
        public DbSet<Recordatorios>? Recordatorios { get; set; }
        public DbSet<Reportes>? Reportes { get; set; }
    }
}