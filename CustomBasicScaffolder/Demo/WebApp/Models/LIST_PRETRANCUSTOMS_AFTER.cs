namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PRETRANCUSTOMS_AFTER")]
    public partial class LIST_PRETRANCUSTOMS_AFTER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PREDECLNO { get; set; }

        [StringLength(50)]
        public string PRETCCODE { get; set; }

        [StringLength(50)]
        public string TRANSMODEL { get; set; }

        [StringLength(50)]
        public string TOOLNO { get; set; }

        [StringLength(50)]
        public string TOOLNAME { get; set; }

        [StringLength(50)]
        public string UNITNO { get; set; }

        [StringLength(50)]
        public string UNITNAME { get; set; }

        [StringLength(50)]
        public string TOOLVOYAGENO { get; set; }

        public DateTime? PREARRIVEDDATE { get; set; }

        [StringLength(50)]
        public string ISES { get; set; }

        [StringLength(50)]
        public string REPWAY { get; set; }

        public decimal? BLORDER { get; set; }

        [StringLength(50)]
        public string BLTOOLNO { get; set; }

        [StringLength(50)]
        public string BLVESSEL { get; set; }

        [StringLength(50)]
        public string BLVOYAGENO { get; set; }

        [StringLength(50)]
        public string BLNO { get; set; }

        public decimal? CONTAINERNUM { get; set; }

        public DateTime? INOUTDATE { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(10)]
        public string XZLB { get; set; }
    }
}
