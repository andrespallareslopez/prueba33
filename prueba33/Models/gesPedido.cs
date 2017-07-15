namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesPedido")]
    public partial class gesPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesPedido()
        {
            gesPedidoDetalles = new HashSet<gesPedidoDetalle>();
        }

        [Key]
        public Guid CodPedido { get; set; }

        public int CodProveedor { get; set; }

        public int? CodTrabajador { get; set; }

        public DateTime? Pedido { get; set; }

        public DateTime? Recibido { get; set; }

        public DateTime? Facturado { get; set; }

        public DateTime? Pagado { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Orden { get; set; }

        [StringLength(150)]
        public string Albaran { get; set; }

        [StringLength(150)]
        public string Factura { get; set; }

        [StringLength(100)]
        public string Forma_pago { get; set; }

        public decimal? Total_pedido { get; set; }

        public decimal? Total_recibido { get; set; }

        public decimal? Total_pagado { get; set; }

        public decimal? Total { get; set; }

        public int? CodFormaPago { get; set; }

        [StringLength(200)]
        public string Observacion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public int? CodTipoPedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesPedidoDetalle> gesPedidoDetalles { get; set; }
    }
}
