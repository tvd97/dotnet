namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fileClassity")]
    public partial class fileClassity
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? sincedate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? todate { get; set; }

        [Column(TypeName = "ntext")]
        public string FileName { get; set; }
    }
}
