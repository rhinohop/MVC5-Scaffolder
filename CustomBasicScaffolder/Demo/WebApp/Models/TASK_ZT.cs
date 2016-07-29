namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_ZT")]
    public partial class TASK_ZT
    {
        [Key]
        [StringLength(50)]
        public string DJBM { get; set; }

        [StringLength(50)]
        public string SBKB { get; set; }

        [StringLength(50)]
        public string ZCTY_NO { get; set; }

        [StringLength(200)]
        public string TGZT { get; set; }

        [StringLength(50)]
        public string QPTY_NO { get; set; }

        [StringLength(50)]
        public string RWRY { get; set; }

        public DateTime? RWSJ { get; set; }

        [StringLength(50)]
        public string KSCX { get; set; }

        [StringLength(50)]
        public string WCBZ { get; set; }
    }
}
