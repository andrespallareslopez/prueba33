namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesProducto")]
    public partial class gesProducto
    {
        [Key]
        public Guid CodProducto { get; set; }

        public int? CodGrupo { get; set; }

        public int? CodFamilia { get; set; }

        public int? CodZona { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        public decimal? Precio { get; set; }
    }
}
