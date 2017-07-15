namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesPedidoDetalle")]
    public partial class gesPedidoDetalle
    {
        [Key]
        public Guid CodDetalle { get; set; }

        public Guid CodPedido { get; set; }

        public int CodArticulo { get; set; }

        public int? CodCatalogo { get; set; }

        public decimal? Debe_haber { get; set; }

        public decimal? Tenemos { get; set; }

        public decimal? Pedimos { get; set; }

        public DateTime? Pedido { get; set; }

        public decimal? PresentacionUnidades { get; set; }

        public decimal? PresentacionPrecio { get; set; }

        [StringLength(100)]
        public string PresentacionFormatoPedido { get; set; }

        [StringLength(100)]
        public string PresentacionFormatoEnvase { get; set; }

        [StringLength(100)]
        public string PresentacionFormatoEmpaquetado { get; set; }

        public DateTime? Recibido { get; set; }

        public bool? Recibi { get; set; }

        [StringLength(50)]
        public string Pedido_por { get; set; }

        [StringLength(50)]
        public string Recibido_por { get; set; }

        public decimal? Precio { get; set; }

        public decimal? Subtotal { get; set; }

        public decimal? Descuento { get; set; }

        public decimal? IVA { get; set; }

        [StringLength(200)]
        public string Observaciones { get; set; }

        public decimal? Cajas { get; set; }

        public virtual gesArticulo gesArticulo { get; set; }

        public virtual gesPedido gesPedido { get; set; }
    }
}
