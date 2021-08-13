namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("lecturer")]
    public partial class lecturer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lecturer()
        {
            projectOfLecturers = new HashSet<projectOfLecturer>();
        }

        [Key]
        [StringLength(10)]
        public string idLecturer { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(20)]
        public string userName { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(10)]
        public string phone { get; set; }

        [StringLength(10)]
        public string idDepartment { get; set; }

        public virtual account account { get; set; }

        public virtual department department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projectOfLecturer> projectOfLecturers { get; set; }
    }
}
