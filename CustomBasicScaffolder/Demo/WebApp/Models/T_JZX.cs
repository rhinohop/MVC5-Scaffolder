namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_JZX")]
    public partial class T_JZX
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string TY_NO { get; set; }

        [StringLength(50)]
        public string JZXH { get; set; }

        [StringLength(50)]
        public string JZXGG { get; set; }

        [StringLength(50)]
        public string JZXZZ { get; set; }

        [StringLength(50)]
        public string XZLB { get; set; }

        [StringLength(50)]
        public string JNYSGJMC { get; set; }

        [StringLength(50)]
        public string DZGSH { get; set; }

        [StringLength(50)]
        public string DJBM { get; set; }
    }
}
