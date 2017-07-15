namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesFamilia")]
    public partial class gesFamilia
    {
      
        public gesFamilia()
        {
            //gesProducto_Num = new HashSet<gesProducto_Num>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodFamilia { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int? CodGrupo { get; set; }

        public bool Activa { get; set; }

        public int? CodZona { get; set; }

        //public virtual gesGrupo gesGrupo { get; set; }

        //public virtual gesZona gesZona { get; set; }

       
        //public virtual ICollection<gesProducto_Num> gesProducto_Num { get; set; }
    }
}
