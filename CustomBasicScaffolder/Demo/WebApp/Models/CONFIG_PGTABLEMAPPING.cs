namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_PGTABLEMAPPING")]
    public partial class CONFIG_PGTABLEMAPPING
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string FILED { get; set; }

        [StringLength(100)]
        public string FILEDNAME { get; set; }

        [StringLength(100)]
        public string CONTROLNAME { get; set; }
    }
}
