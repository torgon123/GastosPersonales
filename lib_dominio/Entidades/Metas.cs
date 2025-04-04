using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Metas
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Monto { get; set; }
        public decimal Progreso { get; set; }
        public bool Finalizado { get; set; }
        public int Id_recordatorio { get; set; }
    }
}