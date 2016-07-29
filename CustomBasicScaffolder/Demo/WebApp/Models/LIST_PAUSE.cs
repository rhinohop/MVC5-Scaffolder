namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PAUSE")]
    public partial class LIST_PAUSE
    {
        public decimal ID { get; set; }

        [StringLength(25)]
        public string CODE { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(25)]
        public string USERNAME { get; set; }

        public DateTime? TIMES { get; set; }

        [StringLength(255)]
        public string REASON { get; set; }

        public decimal? ISEXPIRED { get; set; }
    }
}
