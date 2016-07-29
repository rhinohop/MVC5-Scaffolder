namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSAPPLICATION")]
    public partial class SYSAPPLICATION
    {
        [Key]
        [StringLength(36)]
        public string APPLICATIONID { get; set; }

        [Required]
        [StringLength(50)]
        public string CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        public decimal? SORTINDEX { get; set; }

        public DateTime? LASTMODIFIEDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
