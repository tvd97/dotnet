namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class notification
    {
        [Key]
        public int idNotification { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string title { get; set; }

        [Column(TypeName = "text")]
        public string metaTitle { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string content { get; set; }

        [Column(TypeName = "text")]
        public string FileName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateCreat { get; set; }
    }
}
