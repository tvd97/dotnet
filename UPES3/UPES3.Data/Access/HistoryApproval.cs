namespace UPES3.Data.Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistoryApproval")]
    public partial class HistoryApproval
    {
        public int id { get; set; }

        [StringLength(20)]
        public string idProject { get; set; }

        public DateTime? times { get; set; }

        public int? status { get; set; }

        public virtual projectOfLecturer projectOfLecturer { get; set; }
    }
}
