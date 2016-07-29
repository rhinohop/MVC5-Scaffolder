namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_ROLEMENU")]
    public partial class T_ROLEMENU
    {
        [Key]
        public decimal ROLEMENUID { get; set; }

        public decimal? ROLEID { get; set; }

        public decimal? MENUID { get; set; }
    }
}
