namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FINANCE_BUDGETTYPE")]
    public partial class FINANCE_BUDGETTYPE
    {
        public decimal ID { get; set; }

        [StringLength(30)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        public decimal? ENABLED { get; set; }

        public DateTime? CREATETIME { get; set; }

        public decimal? CREATEMAN { get; set; }

        [StringLength(100)]
        public string CREATEMANNAME { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? STOPMAN { get; set; }

        [StringLength(100)]
        public string STOPMANNAME { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? STARTDATE { get; set; }
    }
}
