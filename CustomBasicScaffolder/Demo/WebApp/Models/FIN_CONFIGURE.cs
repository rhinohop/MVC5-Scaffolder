namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FIN_CONFIGURE")]
    public partial class FIN_CONFIGURE
    {
        [StringLength(50)]
        public string NAMEVALUE { get; set; }

        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string SYMBOL { get; set; }

        [StringLength(200)]
        public string FIELDVALUE { get; set; }

        [StringLength(36)]
        public string RULEID { get; set; }

        [StringLength(50)]
        public string LOGIC { get; set; }

        [StringLength(50)]
        public string PAGEFILEDNUM { get; set; }

        [StringLength(50)]
        public string FILEDTYPE { get; set; }

        [Key]
        public decimal TYPE { get; set; }

        public decimal? RULESEQ { get; set; }
    }
}
