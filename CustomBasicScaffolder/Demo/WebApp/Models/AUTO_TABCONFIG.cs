namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.AUTO_TABCONFIG")]
    public partial class AUTO_TABCONFIG
    {
        public decimal ID { get; set; }

        public decimal? ORDERNO { get; set; }

        [StringLength(20)]
        public string POINTS { get; set; }

        [StringLength(50)]
        public string TABNAME { get; set; }

        [StringLength(20)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(50)]
        public string CUSTOMERNAME { get; set; }
    }
}
