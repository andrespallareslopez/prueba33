namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesFactura")]
    public partial class gesFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesFactura()
        {
            gesFacTiques = new HashSet<gesFacTique>();
            gesFacTique_Num = new HashSet<gesFacTique_Num>();
        }

        [Key]
        public Guid CodFactura { get; set; }

        public DateTime? Abierta { get; set; }

        public DateTime? Facturada { get; set; }

        public DateTime? Cobrada { get; set; }

        public decimal? Importe { get; set; }

        [StringLength(50)]
        public string Mesa { get; set; }

        public int? Pax { get; set; }

        public int? CodCliente { get; set; }

        public Guid? CodTrabajador { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        public int? CodLocal { get; set; }

        public int? Numero { get; set; }

        [StringLength(100)]
        public string Cliente { get; set; }

        public int? CodPeriodo { get; set; }

        [StringLength(100)]
        public string Operador { get; set; }

        [StringLength(50)]
        public string Dispositivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesFacTique> gesFacTiques { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesFacTique_Num> gesFacTique_Num { get; set; }

        public virtual gesTrabajador gesTrabajador { get; set; }
    }
}
