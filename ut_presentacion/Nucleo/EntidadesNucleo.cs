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
            entidad.Id_tipo = 1;
            entidad.Id_categoria = 1;
            entidad.Id_reporte = 1;
            return entidad;
        }
    }
}

