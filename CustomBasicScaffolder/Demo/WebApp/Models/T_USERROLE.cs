namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_USERROLE")]
    public partial class T_USERROLE
    {
        [Key]
        public decimal USERROLEID { get; set; }

        public decimal? USERID { get; set; }

        public decimal? ROLEID { get; set; }
    }
}
