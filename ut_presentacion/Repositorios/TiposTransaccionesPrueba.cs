using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class TiposTransaccionesPrueba
    {
        private readonly IConexion? iConexion;
        private List<Tipos_transacciones>? lista;
        private Tipos_transacciones? entidad;

        public TiposTransaccionesPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.Tipos_transacciones!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Tipos_transacciones()!;
            this.iConexion!.Tipos_transacciones!.Add(this.entidad);
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            //this.entidad!.Activo = true;

            var entry = this.iConexion!.Entry<Tipos_transacciones>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Tipos_transacciones!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}