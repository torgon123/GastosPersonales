using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Conversiones
    {
        public int Id { get; set; }
        public decimal Valor_original { get; set; }
        public decimal Valor_convertido { get; set; }
        public int Id_moneda { get; set; }
    }
}