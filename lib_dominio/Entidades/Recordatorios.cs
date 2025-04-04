namespace lib_dominio.Entidades
{
    public class Recordatorios
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime Fecha_inicial { get; set; }
        public int Frecuencia_dias { get; set; }
    }
}