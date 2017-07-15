namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gesFacTique_Num
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

        public Guid? CodTrabajador { get; set; }

        [StringLength(50)]
        public string Suceso { get; set; }

        [StringLength(50)]
        public string Operacion { get; set; }

        public DateTime? Fecha { get; set; }

        public int? Orden { get; set; }

        public int? CodDispositivo { get; set; }

        public int? CodActividad { get; set; }

        public Guid? Relacion { get; set; }

        [StringLength(50)]
        public string Estadio { get; set; }

        public int? CodCola { get; set; }

        public int? CodProducto_Num { get; set; }

        public DateTime? FechaNegocio { get; set; }

        public virtual gesActividade gesActividade { get; set; }

        public virtual gesFactura gesFactura { get; set; }

        public virtual gesProducto_Num gesProducto_Num { get; set; }

        public virtual gesTrabajador gesTrabajador { get; set; }
    }
}
