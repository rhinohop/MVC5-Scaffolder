namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_MACADDRESS")]
    public partial class SYS_MACADDRESS
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string MACADDRESS { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? ENABLED { get; set; }
    }
}
