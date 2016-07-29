namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSROLEPERMISSION")]
    public partial class SYSROLEPERMISSION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string ROLEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string AUTHID { get; set; }
    }
}
