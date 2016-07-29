namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.AUTO_TEMPLATE")]
    public partial class AUTO_TEMPLATE
    {
        public decimal ID { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string DESCRIBE { get; set; }

        public decimal? MAN { get; set; }

        public DateTime? DATES { get; set; }
    }
}
