using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Transacciones? Transacciones()
        {
            var entidad = new Transacciones();
            entidad.Fecha = DateTime.Now;
            entidad.Id_conversion = 1;
            entidad.Id_tipo_transaccion = 1;
            entidad.Id_categoria = 1;
            entidad.Id_reporte = 1;
            return entidad;
        }

        public static Tipos_transacciones? Tipos_transacciones()
        {
            var entidad = new Tipos_transacciones();
            entidad.Nombre = "income";
            return entidad;
        }

        public static Categorias? Categorias()
        {
            var entidad = new Categorias();
            entidad.Nombre = "Mercado";
            entidad.Descripcion = "Mercado mensual";
            return entidad;
        }

        public static Conversiones? Conversiones()
        {
            var entidad = new Conversiones();
            entidad.Valor_original = 300;
            entidad.Valor_convertido = 1_200_000;
            entidad.Id_moneda = 1;
            return entidad;
        }

        public static Metas? Metas()
        {
            var entidad = new Metas();
            entidad.Nombre = "Cuota inicial apartamento";
            entidad.Monto = 60_000_000;
            entidad.Progreso = 8_000_000;
            entidad.Finalizado = false;
            entidad.Id_recordatorio = 1;
            return entidad;
        }

        public static Reportes? Reportes()
        {
            var entidad = new Reportes();
            entidad.Fecha_final = DateTime.Now;
            entidad.Fecha_inicial = DateTime.Now.AddDays(-30);
            entidad.Saldo = 1_200_000;
            entidad.Total_ingresos = 1_500_000;
            entidad.Total_egresos = 300_000;
            return entidad;
        }
        public static Monedas? Monedas()
        {
            var entidad = new Monedas();
            entidad.Nombre = "USD";
            entidad.Relacion = 4_000;
            return entidad;
        }

        public static Recordatorios? Recordatorios()
        {
            var entidad = new Recordatorios();
            entidad.Nombre = "Recordatorio de cuota inicial";
            entidad.Fecha_inicial = DateTime.Now;
            entidad.Frecuencia_dias = 30;
            return entidad;
        }
    }
}
