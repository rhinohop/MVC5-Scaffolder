namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSMODULE")]
    public partial class SYSMODULE
    {
        [Key]
        [StringLength(36)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(36)]
        public string APPLICATIONID { get; set; }

        [StringLength(36)]
        public string PARENTID { get; set; }

        [StringLength(1000)]
        public string PATH { get; set; }

        public decimal? PATHLEVEL { get; set; }

        public bool? ISLEAF { get; set; }

        [StringLength(500)]
        public string URL { get; set; }

        [StringLength(500)]
        public string ICON { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public short? STATUS { get; set; }

        public short? ISSYSTEM { get; set; }

        public decimal? SORTINDEX { get; set; }

        public bool? ISENTITYPAGE { get; set; }

        public bool? ISQUICKSEARCH { get; set; }

        public bool? ISQUICKCREATE { get; set; }

        public bool? ISRECYCLABLE { get; set; }

        [StringLength(500)]
        public string EDITPAGEURL { get; set; }

        public string AFTEREDITSCRIPT { get; set; }

        public DateTime? LASTMODIFIEDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
