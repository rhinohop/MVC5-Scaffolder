namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSUSERPERMISSION")]
    public partial class SYSUSERPERMISSION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string AUTHID { get; set; }

        [StringLength(36)]
        public string GRANTEDBY { get; set; }

        public DateTime? GRANTDATE { get; set; }
    }
}
