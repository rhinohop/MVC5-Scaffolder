namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_COUNTRY")]
    public partial class BASE_COUNTRY
    {
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string ENGLISHNAME { get; set; }

        [StringLength(50)]
        public string AIRABBREV { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(50)]
        public string OCEANABBREV { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? YEARID { get; set; }

        [StringLength(50)]
        public string RATE { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        public decimal ID { get; set; }

        [StringLength(10)]
        public string EZM { get; set; }
    }
}
