namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSTEMSET")]
    public partial class SYSTEMSET
    {
        public decimal ID { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string VALUE { get; set; }

        [StringLength(100)]
        public string DEFAULTVALUE { get; set; }
    }
}
