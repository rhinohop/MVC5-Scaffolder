namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_ALTERRECORD")]
    public partial class BASE_ALTERRECORD
    {
        public decimal ID { get; set; }

        public decimal? TABID { get; set; }

        public decimal? TABKIND { get; set; }

        public decimal? ALTERMAN { get; set; }

        public DateTime? ALTERDATE { get; set; }

        [StringLength(300)]
        public string REASON { get; set; }

        [StringLength(500)]
        public string CONTENTES { get; set; }
    }
}
