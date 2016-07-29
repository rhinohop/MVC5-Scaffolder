namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_SETPARAMETER")]
    public partial class CONFIG_SETPARAMETER
    {
        public decimal ID { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? NUM { get; set; }
    }
}
