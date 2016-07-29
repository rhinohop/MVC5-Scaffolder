namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_ALTERRECORD")]
    public partial class CONFIG_ALTERRECORD
    {
        public decimal ID { get; set; }

        public decimal? ALTERID { get; set; }

        [StringLength(50)]
        public string ALTERUSER { get; set; }

        public DateTime? ALTERTIME { get; set; }

        [StringLength(255)]
        public string ALTERCONTENT { get; set; }
    }
}
