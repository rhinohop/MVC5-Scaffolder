namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_ELEBACK")]
    public partial class LIST_ELEBACK
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(500)]
        public string REASON { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? TIMES { get; set; }
    }
}
