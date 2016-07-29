namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_INSPRECEIPTSTATUS")]
    public partial class LIST_INSPRECEIPTSTATUS
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        public DateTime? TIMES { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? ISINVALID { get; set; }
    }
}
