namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_PROXYER")]
    public partial class CONFIG_PROXYER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PROXYER { get; set; }

        public decimal? PREMAN { get; set; }

        public DateTime? STARTTIME { get; set; }

        public DateTime? ENDTIME { get; set; }

        [StringLength(500)]
        public string REASON { get; set; }

        public decimal? ENABLED { get; set; }
    }
}
