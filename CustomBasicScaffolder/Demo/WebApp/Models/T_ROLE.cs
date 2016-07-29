namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_ROLE")]
    public partial class T_ROLE
    {
        [Key]
        public decimal ROLEID { get; set; }

        [StringLength(50)]
        public string ROLENAME { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }
    }
}
