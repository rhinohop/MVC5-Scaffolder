namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_PREORDER")]
    public partial class CONFIG_PREORDER
    {
        public decimal ID { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(255)]
        public string CUSTOMERIDS { get; set; }

        [StringLength(255)]
        public string BUSITYPES { get; set; }

        [StringLength(255)]
        public string BUSIUNITCODES { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? PRETYPE { get; set; }

        public decimal? AREAID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }
    }
}
