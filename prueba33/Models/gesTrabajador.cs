namespace prueba33.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gesTrabajador")]
    public partial class gesTrabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gesTrabajador()
        {
            gesFacTique_Num = new HashSet<gesFacTique_Num>();
            gesFacturas = new HashSet<gesFactura>();
        }

        [Key]
        public Guid CodTrabajador { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellidos { get; set; }

        [StringLength(50)]
        public string Alias { get; set; }

        public bool? Activo { get; set; }

        [StringLength(20)]
        public string Fijo { get; set; }

        [StringLength(20)]
        public string Movil { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Localidad { get; set; }

        [StringLength(50)]
        public string Provincia { get; set; }

        [StringLength(10)]
        public string CP { get; set; }

        [StringLength(20)]
        public string DNI { get; set; }

        [StringLength(50)]
        public string SS { get; set; }

        [StringLength(50)]
        public string Banco { get; set; }

        [StringLength(10)]
        public string Clave { get; set; }

        public int? CodEstatus { get; set; }

        public int? CodSeguridad { get; set; }

        public virtual gesEstatu gesEstatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesFacTique_Num> gesFacTique_Num { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gesFactura> gesFacturas { get; set; }
    }
}
