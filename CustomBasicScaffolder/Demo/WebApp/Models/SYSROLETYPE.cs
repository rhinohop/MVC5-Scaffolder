namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSROLETYPE")]
    public partial class SYSROLETYPE
    {
        [Key]
        public decimal ROLETYPEID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }
    }
}
