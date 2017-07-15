namespace prueba33.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Empresarios20 : DbContext
    {
        public Empresarios20()
            : base("name=Empresarios20")
        {
        }

        public virtual DbSet<gesActividade> gesActividades { get; set; }
        public virtual DbSet<gesArqueo> gesArqueos { get; set; }
        public virtual DbSet<gesArqueoDetalle> gesArqueoDetalles { get; set; }
        public virtual DbSet<gesArticulo> gesArticuloes { get; set; }
        public virtual DbSet<gesArticuloClase> gesArticuloClases { get; set; }
        public virtual DbSet<gesCatalogo> gesCatalogoes { get; set; }
        public virtual DbSet<gesEstatu> gesEstatus { get; set; }
        public virtual DbSet<gesFacTique> gesFacTiques { get; set; }
        public virtual DbSet<gesFacTique_Num> gesFacTique_Num { get; set; }
        public virtual DbSet<gesFactura> gesFacturas { get; set; }
        public virtual DbSet<gesFamilia> gesFamilias { get; set; }
        public virtual DbSet<gesGrupo> gesGrupoes { get; set; }
        public virtual DbSet<gesMesa> gesMesas { get; set; }
        public virtual DbSet<gesPedido> gesPedidoes { get; set; }
        public virtual DbSet<gesPedidoDetalle> gesPedidoDetalles { get; set; }
        public virtual DbSet<gesProducto> gesProductoes { get; set; }
        public virtual DbSet<gesProducto_Num> gesProducto_Num { get; set; }
        public virtual DbSet<gesTrabajador> gesTrabajadors { get; set; }
        public virtual DbSet<gesZona> gesZonas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gesActividade>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesArqueo>()
                .Property(e => e.Trabajador)
                .IsUnicode(false);

            modelBuilder.Entity<gesArqueo>()
                .Property(e => e.Centro)
                .IsUnicode(false);

            modelBuilder.Entity<gesArqueo>()
                .Property(e => e.Dispositivo)
                .IsUnicode(false);

            modelBuilder.Entity<gesArqueo>()
                .Property(e => e.Periodo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesArqueoDetalle>()
                .Property(e => e.Realidad)
                .IsUnicode(false);

            modelBuilder.Entity<gesArqueoDetalle>()
                .Property(e => e.Registro)
                .IsUnicode(false);

            modelBuilder.Entity<gesArticulo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesArticulo>()
                .HasMany(e => e.gesPedidoDetalles)
                .WithRequired(e => e.gesArticulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gesArticuloClase>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesArticuloClase>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesArticuloClase>()
                .Property(e => e.NRacion)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesCatalogo>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesCatalogo>()
                .Property(e => e.Importe)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesEstatu>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Suceso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Operacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Dispositivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Actividad)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Familia)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Trabajador)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Periodo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique>()
                .Property(e => e.Estadio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique_Num>()
                .Property(e => e.Detalle)
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique_Num>()
                .Property(e => e.Suceso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique_Num>()
                .Property(e => e.Operacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFacTique_Num>()
                .Property(e => e.Estadio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFactura>()
                .Property(e => e.Mesa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFactura>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<gesFactura>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<gesFactura>()
                .Property(e => e.Operador)
                .IsUnicode(false);

            modelBuilder.Entity<gesFactura>()
                .Property(e => e.Dispositivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesFamilia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesGrupo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesPedido>()
                .Property(e => e.Telefono)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesPedido>()
                .HasMany(e => e.gesPedidoDetalles)
                .WithRequired(e => e.gesPedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Debe_haber)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Tenemos)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Pedimos)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.PresentacionUnidades)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.PresentacionPrecio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Pedido_por)
                .IsUnicode(false);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Recibido_por)
                .IsUnicode(false);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Descuento)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesPedidoDetalle>()
                .Property(e => e.Cajas)
                .HasPrecision(18, 4);

            modelBuilder.Entity<gesProducto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesProducto_Num>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Fijo)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Movil)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Provincia)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.DNI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.SS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Banco)
                .IsUnicode(false);

            modelBuilder.Entity<gesTrabajador>()
                .Property(e => e.Clave)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gesZona>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<gesZona>()
                .Property(e => e.Tipo)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
