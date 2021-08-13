namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("request")]
    public partial class request
    {
        [Key]
        public int idRequest { get; set; }

        [Required]
        [StringLength(20)]
        public string idProject { get; set; }

        [Column("request", TypeName = "ntext")]
        [Required]
        public string request1 { get; set; }

        public int? countMonth { get; set; }

        [Column(TypeName = "ntext")]
        public string cause { get; set; }

        public int? status { get; set; }

        public virtual projectOfLecturer projectOfLecturer { get; set; }
    }
}
