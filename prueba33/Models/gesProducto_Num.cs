namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gesProducto_Num
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesProducto_Num()
        {
            gesFacTique_Num = new HashSet<gesFacTique_Num>();
        }

        public Guid? CodProducto { get; set; }

        public int? CodGrupo { get; set; }

        public int? CodFamilia { get; set; }

        public int? CodZona { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProducto_Num { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        public decimal? Precio { get; set; }

        public bool? ConEscandallo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesFacTique_Num> gesFacTique_Num { get; set; }

        public virtual gesFamilia gesFamilia { get; set; }

        public virtual gesGrupo gesGrupo { get; set; }
    }
}
