namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projectOfStudent")]
    public partial class projectOfStudent
    {
        [Key]
        [StringLength(20)]
        public string idProject { get; set; }

        [Column(TypeName = "ntext")]
        public string nameProject { get; set; }

        [Column(TypeName = "ntext")]
        public string target { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        [Column(TypeName = "ntext")]
        public string nameStudent { get; set; }

        [StringLength(12)]
        public string idStudent { get; set; }

        [StringLength(10)]
        public string idDepartment { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(10)]
        public string idClassity { get; set; }

        public int? countAuthor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateSubmit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateStart { get; set; }

        public int? deadline { get; set; }

        public double? expense { get; set; }

        public int? Status { get; set; }

        public virtual classityType classityType { get; set; }

        public virtual department department { get; set; }
    }
}
