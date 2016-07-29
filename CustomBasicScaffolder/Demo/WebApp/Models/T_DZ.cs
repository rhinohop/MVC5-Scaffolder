namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_DZ")]
    public partial class T_DZ
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string TY_NO { get; set; }

        [StringLength(50)]
        public string DZDM { get; set; }

        [StringLength(50)]
        public string DZBH { get; set; }

        [StringLength(50)]
        public string XZLB { get; set; }

        [StringLength(50)]
        public string DJBM { get; set; }
    }
}
