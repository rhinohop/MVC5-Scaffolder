namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_CONSUMING")]
    public partial class CONFIG_CONSUMING
    {
        public decimal ID { get; set; }

        public decimal? POST { get; set; }

        public decimal? AREA { get; set; }

        public decimal? DATETYPE { get; set; }

        [StringLength(50)]
        public string STARTTIME { get; set; }

        [StringLength(50)]
        public string ENDTIME { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? MAINTAIN { get; set; }

        public DateTime? MAINTAINDATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? ENABLED { get; set; }
    }
}
