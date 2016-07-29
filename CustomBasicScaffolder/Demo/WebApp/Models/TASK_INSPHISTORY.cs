namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_INSPHISTORY")]
    public partial class TASK_INSPHISTORY
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(50)]
        public string TASK { get; set; }

        public DateTime? TIMES { get; set; }
    }
}
