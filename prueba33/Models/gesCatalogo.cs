namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesCatalogo")]
    public partial class gesCatalogo
    {
        [Key]
        public int CodCatalogo { get; set; }

        public int? CodProveedor { get; set; }

        public int? CodArticulo { get; set; }

        public int? CodFormatoPedido { get; set; }

        public int? CodEmpaquetado { get; set; }

        public decimal? Precio { get; set; }

        public bool? Pedir { get; set; }

        public decimal? IVA { get; set; }

        public decimal? Debe_haber { get; set; }

        public decimal? Importe { get; set; }

        public decimal? Contenido_unidad { get; set; }

        public decimal? Contenido_caja { get; set; }

        public bool? PedirCajas { get; set; }

        public bool? Preferente { get; set; }

        public decimal? PrecioUltimoCompra { get; set; }

        public decimal? PrecioMedioCompra { get; set; }

        public virtual gesArticulo gesArticulo { get; set; }
    }
}
