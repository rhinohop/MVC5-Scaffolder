namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_POSITION")]
    public partial class SYS_POSITION
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? DEPARTMENTID { get; set; }

        public DateTime? CREATETIME { get; set; }

        public DateTime? LASTMODIFYTIME { get; set; }

        [StringLength(2000)]
        public string REMARK { get; set; }
    }
}
