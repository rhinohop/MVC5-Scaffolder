namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_YEAR")]
    public partial class BASE_YEAR
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public decimal? CREATEMAN { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? KIND { get; set; }

        public decimal? STOPMAN { get; set; }

        [StringLength(50)]
        public string CUSTOMAREA { get; set; }
    }
}
