namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_PGCUSTOMSMAPPING")]
    public partial class CONFIG_PGCUSTOMSMAPPING
    {
        public decimal ID { get; set; }

        public decimal? PAGECONFIGID { get; set; }

        public decimal? CUSTOMSID { get; set; }

        [StringLength(50)]
        public string CUSTOMSCODE { get; set; }
    }
}
