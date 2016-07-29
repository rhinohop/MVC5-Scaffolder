namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_INSPWRITEMAPPING")]
    public partial class TASK_INSPWRITEMAPPING
    {
        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [Key]
        public decimal KIND { get; set; }

        public decimal? EXCELCOLUMN { get; set; }
    }
}
