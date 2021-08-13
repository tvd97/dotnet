namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("detailStatement")]
    public partial class detailStatement
    {
        [Key]
        public int idDetail { get; set; }

        public int? idStatement { get; set; }

        [StringLength(20)]
        public string idProject { get; set; }

        [Column(TypeName = "ntext")]
        public string countStatement { get; set; }

        [Column(TypeName = "ntext")]
        public string status { get; set; }

        public virtual statement statement { get; set; }

        public virtual projectOfLecturer projectOfLecturer { get; set; }
    }
}
