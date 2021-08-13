namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class statement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public statement()
        {
            detailStatements = new HashSet<detailStatement>();
        }

        [Key]
        public int idStatement { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateStatement { get; set; }

        [Column(TypeName = "ntext")]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detailStatement> detailStatements { get; set; }
    }
}
