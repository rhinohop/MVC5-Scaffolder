namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_PGFROMMAPPING")]
    public partial class CONFIG_PGFROMMAPPING
    {
        public decimal ID { get; set; }

        public decimal? PAGECONFIGID { get; set; }

        public decimal? PAGEID { get; set; }

        [StringLength(100)]
        public string PAGENAME { get; set; }
    }
}
