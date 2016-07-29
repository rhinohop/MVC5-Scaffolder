namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.AUTO_RECORDINFO")]
    public partial class AUTO_RECORDINFO
    {
        public decimal ID { get; set; }

        public decimal? NUM { get; set; }

        public decimal? TEMPLATEID { get; set; }

        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(100)]
        public string POINT { get; set; }

        public decimal? ACTION { get; set; }

        public decimal? CYCLEFLAG { get; set; }

        [StringLength(100)]
        public string CYCLEGROUP { get; set; }

        public decimal? INTERVAL { get; set; }

        [StringLength(100)]
        public string CONFIGFIELDNAME { get; set; }

        [StringLength(100)]
        public string DATAFIELDNAME { get; set; }

        public decimal? MOUSEACTION { get; set; }

        [StringLength(100)]
        public string KEYACTION { get; set; }

        [StringLength(200)]
        public string TESTVALUE { get; set; }
    }
}
