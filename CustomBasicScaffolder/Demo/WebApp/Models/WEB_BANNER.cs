namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.WEB_BANNER")]
    public partial class WEB_BANNER
    {
        [StringLength(36)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(200)]
        public string IMGURL { get; set; }

        [StringLength(200)]
        public string LINKURL { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string STATUS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string FILENAME { get; set; }

        public decimal? SORTINDEX { get; set; }
    }
}
