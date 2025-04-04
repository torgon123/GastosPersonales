using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Transacciones
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_conversion { get; set; }
        public int Id_tipo_transaccion { get; set; }
        public int Id_categoria { get; set; }
        public int Id_reporte { get; set; }
    }
}