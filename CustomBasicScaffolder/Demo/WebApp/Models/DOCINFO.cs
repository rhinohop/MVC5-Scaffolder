namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.DOCINFOS")]
    public partial class DOCINFO
    {
        [StringLength(20)]
        public string DJBM { get; set; }

        [StringLength(20)]
        public string SFDZDM { get; set; }

        [StringLength(20)]
        public string SFDZBH { get; set; }

        public decimal ID { get; set; }
    }
}
