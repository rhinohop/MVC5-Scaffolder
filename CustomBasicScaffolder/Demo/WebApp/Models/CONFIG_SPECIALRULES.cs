namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_SPECIALRULES")]
    public partial class CONFIG_SPECIALRULES
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(200)]
        public string CUSTOMER { get; set; }

        [StringLength(200)]
        public string BUSIUNIT { get; set; }

        [StringLength(200)]
        public string BUSITYPE { get; set; }

        public decimal? HEADBODY { get; set; }

        [StringLength(200)]
        public string TRADE { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? ALTERMAN { get; set; }

        public DateTime? CREATETIME { get; set; }

        public DateTime? ALTERTIME { get; set; }

        [StringLength(200)]
        public string PROFILE { get; set; }

        [StringLength(500)]
        public string CONTENT { get; set; }

        [StringLength(200)]
        public string IMGPATH { get; set; }

        [StringLength(500)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(500)]
        public string BUSIUNITNAME { get; set; }

        [StringLength(500)]
        public string BUSITYPENAME { get; set; }

        [StringLength(500)]
        public string TRADENAME { get; set; }
    }
}
