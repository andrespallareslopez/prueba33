namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesArqueoDetalle")]
    public partial class gesArqueoDetalle
    {
        [Key]
        public Guid CodDetalle { get; set; }

        public Guid? CodArqueo { get; set; }

        [StringLength(100)]
        public string Realidad { get; set; }

        public decimal? Contado { get; set; }

        [StringLength(100)]
        public string Registro { get; set; }

        public decimal? Vendido { get; set; }

        public decimal? Diferencia { get; set; }

        public int? Periodo { get; set; }

        public virtual gesArqueo gesArqueo { get; set; }
    }
}
