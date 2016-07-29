namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_DECLHSTYPE")]
    public partial class BASE_DECLHSTYPE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(300)]
        public string NAME { get; set; }

        public decimal? CREATEMAN { get; set; }

        public DateTime? CREATETIME { get; set; }
    }
}
