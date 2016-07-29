namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_CONTAINERTYPE")]
    public partial class BASE_CONTAINERTYPE
    {
        public decimal ID { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(20)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string CONTAINERCODE { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
