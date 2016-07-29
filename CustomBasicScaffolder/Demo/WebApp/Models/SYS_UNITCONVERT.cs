namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_UNITCONVERT")]
    public partial class SYS_UNITCONVERT
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string UNITCODE1 { get; set; }

        [StringLength(50)]
        public string UNITCODE2 { get; set; }

        [Column(TypeName = "float")]
        public decimal? CONVERTRATE { get; set; }

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
