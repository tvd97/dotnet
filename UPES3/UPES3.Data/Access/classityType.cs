namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("classityType")]
    public partial class classityType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public classityType()
        {
            projectOfLecturers = new HashSet<projectOfLecturer>();
            projectOfStudents = new HashSet<projectOfStudent>();
        }

        [Key]
        [StringLength(10)]
        public string idClassity { get; set; }

        [StringLength(10)]
        public string idType { get; set; }

        [Column(TypeName = "ntext")]
        public string name { get; set; }

        public double? timeNum { get; set; }

        public double? pointStd { get; set; }

        public double? pointLect { get; set; }

        public virtual type type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projectOfLecturer> projectOfLecturers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projectOfStudent> projectOfStudents { get; set; }
    }
}
