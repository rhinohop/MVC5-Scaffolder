namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BGDZT")]
    public partial class BGDZT
    {
        [Key]
        [StringLength(50)]
        public string DJBM { get; set; }

        [StringLength(50)]
        public string ZCTY_NO { get; set; }

        [StringLength(50)]
        public string QPTY_NO { get; set; }

        [StringLength(50)]
        public string HG_NO { get; set; }

        [StringLength(200)]
        public string TGZT { get; set; }

        [StringLength(50)]
        public string SJBZ { get; set; }

        public DateTime? ZTSJ { get; set; }
    }
}
