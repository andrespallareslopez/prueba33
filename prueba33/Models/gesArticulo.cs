namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesArticulo")]
    public partial class gesArticulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesArticulo()
        {
            gesCatalogoes = new HashSet<gesCatalogo>();
            gesPedidoDetalles = new HashSet<gesPedidoDetalle>();
        }

        [Key]
        public int CodArticulo { get; set; }

        public int? CodGrupo { get; set; }

        public int? CodFamilia { get; set; }

        public int? CodEnvase { get; set; }

        public int? CodMagnitud { get; set; }

        public int? CodGrupoCompra { get; set; }

        public int? CodSectorPedido { get; set; }

        public int? CodClase { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public bool? Activo { get; set; }

        public decimal? Contenido_unidad { get; set; }

        public decimal? Contenido_caja { get; set; }

        public decimal? Existencias { get; set; }

        public decimal? Debe_haber { get; set; }

        public decimal? PrecioUltimoCompra { get; set; }

        public decimal? PrecioMedioCompra { get; set; }

        public decimal? FactorEnvase { get; set; }

        public decimal? CantidadEnvase { get; set; }

        public decimal? PesoNeto { get; set; }

        public virtual gesArticuloClase gesArticuloClase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesCatalogo> gesCatalogoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesPedidoDetalle> gesPedidoDetalles { get; set; }
    }
}
