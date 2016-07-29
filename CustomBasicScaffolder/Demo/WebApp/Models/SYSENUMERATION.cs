namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSENUMERATION")]
    public partial class SYSENUMERATION
    {
        [StringLength(36)]
        public string ID { get; set; }

        [Required]
        [StringLength(150)]
        public string CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string VALUE { get; set; }

        [StringLength(36)]
        public string PARENTID { get; set; }

        [StringLength(500)]
        public string PATH { get; set; }

        public decimal? PATHLEVEL { get; set; }

        public bool? ISLEAF { get; set; }

        public decimal? SORTINDEX { get; set; }

        [StringLength(50)]
        public string EDITSTATUS { get; set; }

        [StringLength(500)]
        public string TAG { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [StringLength(36)]
        public string CREATERID { get; set; }

        [StringLength(36)]
        public string CREATERNAME { get; set; }

        public DateTime? LASTMODIFIEDDATE { get; set; }

        public DateTime? CREATEDDATE { get; set; }

        [StringLength(100)]
        public string POSTLAVEL { get; set; }

        [StringLength(36)]
        public string COMPANYID { get; set; }

        [StringLength(100)]
        public string COMPANYNAME { get; set; }

        [StringLength(36)]
        public string DEPTID { get; set; }

        [StringLength(100)]
        public string DEPTNAME { get; set; }

        [StringLength(100)]
        public string EXT1 { get; set; }

        [StringLength(100)]
        public string EXT2 { get; set; }

        [StringLength(100)]
        public string EXT3 { get; set; }

        [StringLength(100)]
        public string EXT4 { get; set; }

        [StringLength(100)]
        public string EXT5 { get; set; }
    }
}
