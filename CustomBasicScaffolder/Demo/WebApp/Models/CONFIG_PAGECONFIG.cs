namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_PAGECONFIG")]
    public partial class CONFIG_PAGECONFIG
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string PAGENAME { get; set; }

        public decimal? PCTYPE { get; set; }

        public decimal? PAGETYPE { get; set; }

        [StringLength(2000)]
        public string REASON { get; set; }

        [StringLength(2000)]
        public string RESULT { get; set; }

        public decimal? ENABLE { get; set; }

        public decimal? CONFIGBY { get; set; }

        public DateTime? CONFIGDATE { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        [StringLength(1000)]
        public string RESULTDOC { get; set; }

        [StringLength(1000)]
        public string RESULTENABLE { get; set; }

        [StringLength(1000)]
        public string RESULTCHECKED { get; set; }

        [StringLength(1000)]
        public string RESULTUNENABLE { get; set; }

        [StringLength(1000)]
        public string RESULTUNCHECKED { get; set; }

        public decimal? WARNING { get; set; }

        [StringLength(1000)]
        public string CONTENT { get; set; }

        [StringLength(1000)]
        public string CUTOMS { get; set; }

        public decimal? PAGEID { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(20)]
        public string APPLYTYPE { get; set; }
    }
}
