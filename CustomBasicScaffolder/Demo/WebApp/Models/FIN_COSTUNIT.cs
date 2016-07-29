namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FIN_COSTUNIT")]
    public partial class FIN_COSTUNIT
    {
        public decimal? ID { get; set; }

        [Key]
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

        [StringLength(200)]
        public string REMARK { get; set; }

        public DateTime? STARTDATE { get; set; }
    }
}
