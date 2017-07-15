namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesMesa")]
    public partial class gesMesa
    {
        [Key]
        public int CodMesa { get; set; }

        public int Mesa { get; set; }

        public int? Pax { get; set; }

        public bool? Activa { get; set; }

        public int? CodZona { get; set; }

        public int? CodLocal { get; set; }
    }
}
