namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_FTPSETTINGS")]
    public partial class SYS_FTPSETTINGS
    {
        public decimal ID { get; set; }

        [StringLength(100)]
        public string PROFILENAME { get; set; }

        [StringLength(200)]
        public string URI { get; set; }

        [StringLength(100)]
        public string PORT { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(100)]
        public string CHANNELNAME { get; set; }

        [StringLength(50)]
        public string FILETYPE { get; set; }

        [StringLength(50)]
        public string CUSTOMDISTRICTCODE { get; set; }

        [StringLength(50)]
        public string ENTRUSTTYPE { get; set; }
    }
}
