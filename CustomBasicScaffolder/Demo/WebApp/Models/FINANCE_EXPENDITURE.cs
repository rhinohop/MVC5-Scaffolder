namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FINANCE_EXPENDITURE")]
    public partial class FINANCE_EXPENDITURE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        public decimal? ENABLED { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string CREATEMANNAME { get; set; }
    }
}
