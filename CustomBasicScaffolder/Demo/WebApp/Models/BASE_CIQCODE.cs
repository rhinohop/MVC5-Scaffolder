namespace WebApp.Models
{
    using Repository.Pattern.Ef6;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_CIQCODE")]
    public partial class BASE_CIQCODE:Entity
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CIQ { get; set; }

        [StringLength(200)]
        public string CIQNAME { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? YEARID { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }
    }
}
