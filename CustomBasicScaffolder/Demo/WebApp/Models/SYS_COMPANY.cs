namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_COMPANY")]
    public partial class SYS_COMPANY
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }
    }
}
