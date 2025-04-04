namespace lib_dominio.Entidades
{
    public class Reportes
    {
        public int Id { get; set; }
        public DateTime Fecha_inicial { get; set; }
        public DateTime Fecha_final { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total_ingresos { get; set; }
        public decimal Total_egresos { get; set; }
        
        
    }
}