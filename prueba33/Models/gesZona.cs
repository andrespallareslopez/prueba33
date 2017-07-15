namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gesZona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesZona()
        {
            gesFamilias = new HashSet<gesFamilia>();
        }

        [Key]
        public int CodZona { get; set; }

        public int? CodLocal { get; set; }

        public int? CodDispositivo { get; set; }

        public int? CodActividad { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public bool? Activa { get; set; }

        [StringLength(50)]
        public string Tipo { get; set; }

        public virtual gesActividade gesActividade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesFamilia> gesFamilias { get; set; }
    }
}
