namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSROLE")]
    public partial class SYSROLE
    {
        [Key]
        [StringLength(36)]
        public string ROLEID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        public decimal? TYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        public decimal? SORTINDEX { get; set; }

        public DateTime? LASTMODIFIEDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(50)]
        public string SUPORIOR { get; set; }

        [StringLength(36)]
        public string PK_CORP { get; set; }

        [StringLength(36)]
        public string PK_DEPTDOC { get; set; }

        [StringLength(36)]
        public string PK_GWDJ { get; set; }

        public decimal? WORTOUT { get; set; }

        [StringLength(1)]
        public string ISABORT { get; set; }

        [StringLength(10)]
        public string ABORTDATE { get; set; }
    }
}
