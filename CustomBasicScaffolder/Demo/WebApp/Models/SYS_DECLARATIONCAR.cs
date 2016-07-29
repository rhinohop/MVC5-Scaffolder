namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_DECLARATIONCAR")]
    public partial class SYS_DECLARATIONCAR
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string LICENSE { get; set; }

        [StringLength(50)]
        public string WHITECARD { get; set; }

        [StringLength(50)]
        public string MODELS { get; set; }

        [StringLength(50)]
        public string MOTORCADE { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? ENABLED { get; set; }
    }
}
