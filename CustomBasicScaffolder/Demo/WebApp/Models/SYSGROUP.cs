namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSGROUP")]
    public partial class SYSGROUP
    {
        [Key]
        [StringLength(36)]
        public string GROUPID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(30)]
        public string CODE { get; set; }

        [StringLength(36)]
        public string PARENTID { get; set; }

        [StringLength(1000)]
        public string PATH { get; set; }

        public decimal? PATHLEVEL { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? SORTINDEX { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public decimal? MODIFIEDSORTINDEX { get; set; }

        public DateTime? LASTMODIFIEDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string HRCANCELED { get; set; }

        [StringLength(36)]
        public string PK_PSNDOC { get; set; }

        [StringLength(36)]
        public string PK_PSNDOC2 { get; set; }

        [StringLength(36)]
        public string PK_PSNDOC3 { get; set; }

        public decimal? WORTOUT { get; set; }

        [StringLength(50)]
        public string ISABORT { get; set; }

        [StringLength(50)]
        public string ABORTDATE { get; set; }
    }
}
