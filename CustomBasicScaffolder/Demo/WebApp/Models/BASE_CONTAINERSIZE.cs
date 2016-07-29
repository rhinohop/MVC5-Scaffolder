namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_CONTAINERSIZE")]
    public partial class BASE_CONTAINERSIZE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(300)]
        public string DECLSIZE { get; set; }

        [StringLength(50)]
        public string INSPECTION { get; set; }

        [StringLength(50)]
        public string DECLARATION { get; set; }

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
