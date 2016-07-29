namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_ZGFY")]
    public partial class T_ZGFY
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string TY_NO { get; set; }

        [StringLength(50)]
        public string ZGSBDH { get; set; }

        [StringLength(50)]
        public string JNYSFS { get; set; }

        [StringLength(50)]
        public string JNYSGJBH { get; set; }

        [StringLength(50)]
        public string JNYSGJMC { get; set; }

        [StringLength(50)]
        public string JNYSGJHC { get; set; }

        [StringLength(50)]
        public string DZGS { get; set; }

        [StringLength(50)]
        public string CYDWBH { get; set; }

        [StringLength(50)]
        public string CYDWMC { get; set; }

        public DateTime? YDRQ { get; set; }

        [StringLength(50)]
        public string SBLX { get; set; }

        [StringLength(50)]
        public string YSGJBH { get; set; }

        [StringLength(50)]
        public string HCTD { get; set; }

        [StringLength(50)]
        public string CBMC { get; set; }

        [StringLength(50)]
        public string ZGHC { get; set; }

        public DateTime? JCJRQ { get; set; }

        [StringLength(50)]
        public string XZLB { get; set; }

        [StringLength(50)]
        public string DJBM { get; set; }
    }
}
