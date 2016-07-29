namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSEVENTTYPE")]
    public partial class SYSEVENTTYPE
    {
        [Key]
        public decimal EVENTTYPEID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }
    }
}
