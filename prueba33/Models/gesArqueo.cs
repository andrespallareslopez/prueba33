namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesArqueo")]
    public partial class gesArqueo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesArqueo()
        {
            gesArqueoDetalles = new HashSet<gesArqueoDetalle>();
        }

        [Key]
        public Guid CodArqueo { get; set; }

        public int Orden { get; set; }

        public DateTime? Fecha { get; set; }

        public int? CodTrabajador { get; set; }

        [StringLength(150)]
        public string Trabajador { get; set; }

        public int? CodLocal { get; set; }

        [StringLength(100)]
        public string Centro { get; set; }

        public int? CodDispositivo { get; set; }

        [StringLength(100)]
        public string Dispositivo { get; set; }

        public bool? Comprobado { get; set; }

        public DateTime? Dia { get; set; }

        public int? CodPeriodo { get; set; }

        [StringLength(50)]
        public string Periodo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesArqueoDetalle> gesArqueoDetalles { get; set; }
    }
}
