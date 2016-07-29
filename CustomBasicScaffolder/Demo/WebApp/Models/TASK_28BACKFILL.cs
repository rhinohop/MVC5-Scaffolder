namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_28BACKFILL")]
    public partial class TASK_28BACKFILL
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        public decimal? NODES { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? ISBACK { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
