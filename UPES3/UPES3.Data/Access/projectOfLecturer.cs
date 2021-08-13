namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projectOfLecturer")]
    public partial class projectOfLecturer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public projectOfLecturer()
        {
            detailStatements = new HashSet<detailStatement>();
            HistoryApprovals = new HashSet<HistoryApproval>();
            progressProjects = new HashSet<progressProject>();
            requests = new HashSet<request>();
        }

        [Key]
        [StringLength(20)]
        public string idProject { get; set; }

        [Column(TypeName = "ntext")]
        public string nameProject { get; set; }

        [Column(TypeName = "ntext")]
        public string target { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        [StringLength(10)]
        public string idLecturer { get; set; }

        [StringLength(10)]
        public string idClassity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateSubmit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateStart { get; set; }

        public int? deadline { get; set; }

        public double? expense { get; set; }

        public int? status { get; set; }

        public int? countAuthor { get; set; }

        [Column(TypeName = "ntext")]
        public string point { get; set; }

        [Column(TypeName = "ntext")]
        public string scholastic { get; set; }

        public virtual classityType classityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detailStatement> detailStatements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryApproval> HistoryApprovals { get; set; }

        public virtual lecturer lecturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<progressProject> progressProjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<request> requests { get; set; }
    }
}
