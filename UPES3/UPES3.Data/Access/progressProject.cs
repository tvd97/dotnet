namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("progressProject")]
    public partial class progressProject
    {
        [Key]
        public int idProgress { get; set; }

        [StringLength(20)]
        public string idProject { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [Column(TypeName = "ntext")]
        public string status { get; set; }

        public virtual projectOfLecturer projectOfLecturer { get; set; }
    }
}
