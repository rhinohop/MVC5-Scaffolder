namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_NOTICE")]
    public partial class CONFIG_NOTICE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [StringLength(1000)]
        public string CONTENT { get; set; }

        public decimal? CREATEMAN { get; set; }

        [StringLength(50)]
        public string STARTTIME { get; set; }

        [StringLength(50)]
        public string ENDTIME { get; set; }

        public decimal? DATETYPE { get; set; }

        public decimal? DATENUM { get; set; }

        public decimal? FREQUENCY { get; set; }

        public decimal? STATUS { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
