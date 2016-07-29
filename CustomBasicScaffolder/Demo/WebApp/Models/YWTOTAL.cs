namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.YWTOTAL")]
    public partial class YWTOTAL
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string TY_NO { get; set; }

        [StringLength(50)]
        public string ITYPE { get; set; }

        [StringLength(50)]
        public string IC_NO { get; set; }

        [StringLength(50)]
        public string LYNAME { get; set; }

        [StringLength(50)]
        public string SDATE { get; set; }

        [StringLength(50)]
        public string SBHG { get; set; }

        [StringLength(50)]
        public string SPXS { get; set; }

        [StringLength(50)]
        public string ZT { get; set; }

        [StringLength(50)]
        public string SBNO { get; set; }

        [StringLength(50)]
        public string XZLB { get; set; }

        [StringLength(50)]
        public string DJBM { get; set; }
    }
}
