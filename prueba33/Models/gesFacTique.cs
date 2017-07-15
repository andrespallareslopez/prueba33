namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesFacTique")]
    public partial class gesFacTique
    {
        [Key]
        public Guid CodDetalle { get; set; }

        public Guid? CodFactura { get; set; }

        public Guid? CodProducto { get; set; }

        [StringLength(150)]
        public string Detalle { get; set; }

        public int? Unidad { get; set; }

        public decimal? Importe { get; set; }

        public decimal? SubTotal { get; set; }

        public int? CodTrabajador { get; set; }

        [StringLength(50)]
        public string Suceso { get; set; }

        [StringLength(50)]
        public string Operacion { get; set; }

        public DateTime? Fecha { get; set; }

        public int Orden { get; set; }

        public int? CodDispositivo { get; set; }

        [StringLength(50)]
        public string Dispositivo { get; set; }

        [StringLength(100)]
        public string Actividad { get; set; }

        public int? CodZona { get; set; }

        [StringLength(100)]
        public string Zona { get; set; }

        public int? CodGrupo { get; set; }

        [StringLength(100)]
        public string Grupo { get; set; }

        public int? CodFamilia { get; set; }

        [StringLength(100)]
        public string Familia { get; set; }

        public int? CodActividad { get; set; }

        public int? Mesa { get; set; }

        [StringLength(100)]
        public string Cliente { get; set; }

        [StringLength(100)]
        public string Trabajador { get; set; }

        public int? CodPeriodo { get; set; }

        [StringLength(50)]
        public string Periodo { get; set; }

        public bool? Activo { get; set; }

        public Guid? Relacion { get; set; }

        [StringLength(50)]
        public string Estadio { get; set; }

        public int? CodCola { get; set; }

        public virtual gesFactura gesFactura { get; set; }
    }
}
