namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PREDECLLIST")]
    public partial class LIST_PREDECLLIST
    {
        public decimal ID { get; set; }

        public decimal? PREDECLID { get; set; }

        public decimal? ORDERNO { get; set; }

        [StringLength(10)]
        public string ITEMNO { get; set; }

        [StringLength(50)]
        public string COMMODITYNO { get; set; }

        [StringLength(10)]
        public string ADDITIONALNO { get; set; }

        [StringLength(100)]
        public string COMMODITYNAME { get; set; }

        [StringLength(500)]
        public string SPECIFICATIONSMODEL { get; set; }

        [Column(TypeName = "float")]
        public decimal? LEGALQUANTITY { get; set; }

        [StringLength(10)]
        public string LEGALUNIT { get; set; }

        [Column(TypeName = "float")]
        public decimal? SQUANTITY { get; set; }

        [StringLength(10)]
        public string SUNIT { get; set; }

        [Column(TypeName = "float")]
        public decimal? CADQUANTITY { get; set; }

        [StringLength(10)]
        public string CADUNIT { get; set; }

        [Column(TypeName = "float")]
        public decimal? UNITPRICE { get; set; }

        [Column(TypeName = "float")]
        public decimal? TOTALPRICE { get; set; }

        [StringLength(20)]
        public string CURRENCY { get; set; }

        [StringLength(10)]
        public string CURRENCYCODE { get; set; }

        [StringLength(20)]
        public string TAXPAID { get; set; }

        [StringLength(50)]
        public string VERSIONNO { get; set; }

        [StringLength(50)]
        public string ARTNO { get; set; }

        [Column(TypeName = "float")]
        public decimal? PROCESSINGFEES { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSNW { get; set; }

        [StringLength(50)]
        public string LICENSENO { get; set; }

        [StringLength(10)]
        public string ISOUEQUIPMENT { get; set; }

        [StringLength(10)]
        public string ISWASTEMATERIALS { get; set; }

        [StringLength(10)]
        public string ISFORCELAWCONDITION { get; set; }

        [StringLength(50)]
        public string PURPOSE { get; set; }

        [StringLength(50)]
        public string CUSTOMREGULATORY { get; set; }

        [StringLength(50)]
        public string INSPECTIONREGULATORY { get; set; }

        [StringLength(50)]
        public string CIQCODE { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(50)]
        public string PREDECLCODE { get; set; }

        [StringLength(20)]
        public string COUNTRYORIGIN { get; set; }

        [StringLength(20)]
        public string COUNTRYORIGINCODE { get; set; }

        [StringLength(20)]
        public string UNITYCODE { get; set; }

        public decimal? NEWNO { get; set; }

        public decimal? ISSPECIAL { get; set; }

        [StringLength(50)]
        public string DESTCOUNTRYCODE { get; set; }

        [StringLength(50)]
        public string DESTCOUNTRYNAME { get; set; }
    }
}
