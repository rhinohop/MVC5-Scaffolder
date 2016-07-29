namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_SPECIALHSCONVERT")]
    public partial class BASE_SPECIALHSCONVERT
    {
        public decimal ID { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(20)]
        public string EXTRACODE { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string UNIT1 { get; set; }

        [StringLength(50)]
        public string UNIT2 { get; set; }

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
