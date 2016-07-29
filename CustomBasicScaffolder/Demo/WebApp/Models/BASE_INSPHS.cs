namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_INSPHS")]
    public partial class BASE_INSPHS
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string HSCODE { get; set; }

        [StringLength(250)]
        public string HSNAME { get; set; }

        [StringLength(50)]
        public string WEIGHT { get; set; }

        [StringLength(50)]
        public string CUSTOMREGULATORY { get; set; }

        [StringLength(50)]
        public string NUM { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? YEARID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string INSPECTIONREGULATORY { get; set; }

        [StringLength(20)]
        public string LEGALUNIT { get; set; }

        [StringLength(20)]
        public string EXTRACODE { get; set; }
    }
}
