namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_WARNING")]
    public partial class CONFIG_WARNING
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ACCORD { get; set; }

        [StringLength(50)]
        public string PAGES { get; set; }

        [StringLength(50)]
        public string COLORS { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string CONDITION { get; set; }

        [StringLength(500)]
        public string CONTENT { get; set; }

        [StringLength(50)]
        public string WARNINGVALUE { get; set; }

        [StringLength(20)]
        public string STATUS { get; set; }

        public decimal? CREATEMAN { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? ALTERMAN { get; set; }

        public DateTime? ALTERDATE { get; set; }

        public decimal? ENABLEMAN { get; set; }

        public DateTime? ENABLEDATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? CONDITION5 { get; set; }
    }
}
