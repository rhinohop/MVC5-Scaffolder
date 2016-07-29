namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSSYSTEM")]
    public partial class SYSSYSTEM
    {
        [Key]
        [StringLength(36)]
        public string SYSTEMID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string VERSION { get; set; }

        [StringLength(2000)]
        public string SYSTEMCONFIGDATA { get; set; }

        public decimal? ISCURRENT { get; set; }
    }
}
