namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSAUTHTYPE")]
    public partial class SYSAUTHTYPE
    {
        [Key]
        public decimal AUTHTYPEID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }
    }
}
