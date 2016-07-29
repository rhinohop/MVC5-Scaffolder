namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_ZC")]
    public partial class TASK_ZC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SBKB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BA_NO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string QSXH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string JSXH { get; set; }

        [StringLength(10)]
        public string JGFS { get; set; }

        [StringLength(10)]
        public string YSFS { get; set; }

        [StringLength(1)]
        public string XZZT { get; set; }
    }
}
