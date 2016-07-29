namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_CODE")]
    public partial class SYS_CODE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        public decimal? ISENABLED { get; set; }

        [StringLength(6)]
        public string YEARMONTH { get; set; }

        public DateTime? CREATETIME { get; set; }
    }
}
