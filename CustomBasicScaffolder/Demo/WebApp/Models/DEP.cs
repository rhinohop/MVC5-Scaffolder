namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.DEP")]
    public partial class DEP
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string DEP_NAME { get; set; }
    }
}
