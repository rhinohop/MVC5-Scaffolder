namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSAUTH")]
    public partial class SYSAUTH
    {
        [Key]
        [StringLength(36)]
        public string AUTHID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(36)]
        public string PARENTID { get; set; }

        [StringLength(1000)]
        public string PATH { get; set; }

        public decimal? PATHLEVEL { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(36)]
        public string MODULEID { get; set; }

        [StringLength(500)]
        public string DATA { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public decimal? SORTINDEX { get; set; }

        public DateTime? LASTMODIFIEDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
