namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesArticuloClase")]
    public partial class gesArticuloClase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesArticuloClase()
        {
            gesArticuloes = new HashSet<gesArticulo>();
        }

        [Key]
        public int CodClase { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public bool? Activo { get; set; }

        public bool? ConEscandallo { get; set; }

        public decimal? Cantidad { get; set; }

        public int? CodMagnitud { get; set; }

        public bool? DescontarExistencias { get; set; }

        public decimal? NRacion { get; set; }

        public bool? ParaPreparacion { get; set; }

        public bool? ParaProducto { get; set; }

        public bool? CalculoPorPeso { get; set; }

        public bool? CalculoPorRacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesArticulo> gesArticuloes { get; set; }
    }
}
