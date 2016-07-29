namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PREDECLCONTAINER")]
    public partial class LIST_PREDECLCONTAINER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        public decimal? CONTAINERORDER { get; set; }

        [StringLength(50)]
        public string CONTAINERNO { get; set; }

        [StringLength(50)]
        public string CONTAINERSIZEE { get; set; }

        [StringLength(50)]
        public string CONTAINERSIZE { get; set; }

        [Column(TypeName = "float")]
        public decimal? CONTAINERWEIGHT { get; set; }

        [StringLength(50)]
        public string CONTAINERTYPE { get; set; }

        [StringLength(50)]
        public string HSCODE { get; set; }

        [StringLength(50)]
        public string CONTSPECIFICATIONS { get; set; }

        [StringLength(50)]
        public string CDCARNO { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(50)]
        public string CDCARNAME { get; set; }

        [StringLength(50)]
        public string UNITNO { get; set; }

        [StringLength(50)]
        public string ELESHUT { get; set; }

        [StringLength(50)]
        public string FORMATNAME { get; set; }

        [StringLength(10)]
        public string XZLB { get; set; }
    }
}
