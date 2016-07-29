namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PRETCCGMAPPING")]
    public partial class LIST_PRETCCGMAPPING
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PRETCCODE { get; set; }

        public decimal? GOODSORDER { get; set; }

        public decimal? CONTAINERORDER { get; set; }

        [StringLength(50)]
        public string CONTAINERNO { get; set; }

        public decimal? GOODSNUM { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSWEIGHT { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public decimal? ISINVALID { get; set; }
    }
}
