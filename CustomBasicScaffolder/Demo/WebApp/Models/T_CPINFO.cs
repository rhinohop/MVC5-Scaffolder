namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_CPINFO")]
    public partial class T_CPINFO
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string JNYSGJBH { get; set; }

        [StringLength(50)]
        public string JNYSGJMC { get; set; }

        [StringLength(50)]
        public string CYDWBH { get; set; }

        [StringLength(50)]
        public string CYDWMC { get; set; }

        [StringLength(10)]
        public string SJBZ { get; set; }
    }
}
