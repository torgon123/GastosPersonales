using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Transacciones>? Transacciones { get; set; }
        DbSet<Tipos_transacciones>? Tipos_transacciones { get; set; }
        DbSet<Categorias>? Categorias { get; set; }
        DbSet<Conversiones>? Conversiones { get; set; }
        DbSet<Metas>? Metas { get; set; }
        DbSet<Monedas>? Monedas { get; set; }
        DbSet<Recordatorios>? Recordatorios { get; set; }
        DbSet<Reportes>? Reportes { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}