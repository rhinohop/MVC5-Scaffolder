namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PREINSPLIST")]
    public partial class LIST_PREINSPLIST
    {
        public decimal ID { get; set; }

        public decimal? PREINSPID { get; set; }

        public decimal? ORDERNO { get; set; }

        [StringLength(10)]
        public string ITEMNO { get; set; }

        [StringLength(50)]
        public string COMMODITYNO { get; set; }

        [StringLength(10)]
        public string ADDITIONALNO { get; set; }

        [StringLength(50)]
        public string CIQCODE { get; set; }

        [StringLength(50)]
        public string CUSTOMREGULATORY { get; set; }

        [StringLength(50)]
        public string INSPECTIONREGULATORY { get; set; }

        [StringLength(50)]
        public string COMMODITYNAME { get; set; }

        [StringLength(500)]
        public string COMMODITYEN { get; set; }

        public decimal? GOODSNUM { get; set; }

        [StringLength(10)]
        public string PACKAGETYPE { get; set; }

        [Column(TypeName = "float")]
        public decimal? LEGALQUANTITY { get; set; }

        [StringLength(10)]
        public string LEGALUNIT { get; set; }

        [Column(TypeName = "float")]
        public decimal? SQUANTITY { get; set; }

        [StringLength(10)]
        public string SUNIT { get; set; }

        [Column(TypeName = "float")]
        public decimal? UNITPRICE { get; set; }

        [Column(TypeName = "float")]
        public decimal? TOTALPRICE { get; set; }

        [StringLength(20)]
        public string CURRENCY { get; set; }

        [StringLength(10)]
        public string CURRENCYCODE { get; set; }

        [StringLength(20)]
        public string COUNTRYORIGIN { get; set; }

        [StringLength(20)]
        public string COUNTRYORIGINCODE { get; set; }

        [StringLength(50)]
        public string PURPOSE { get; set; }

        [StringLength(10)]
        public string ISOUEQUIPMENT { get; set; }

        [StringLength(10)]
        public string ISWASTEGOODS { get; set; }

        [StringLength(10)]
        public string ISFORCELAWCONDITION { get; set; }

        [StringLength(10)]
        public string ISSPECIALGOODS { get; set; }

        [StringLength(50)]
        public string LICENSENO { get; set; }

        [StringLength(50)]
        public string PRODUCTIONUNITCODE { get; set; }

        [StringLength(100)]
        public string PRODUCTIONUNITNAME { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSLENGTH { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSWIDTH { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSHIGH { get; set; }

        [StringLength(100)]
        public string GOODSSPECIFICATIONS { get; set; }

        public decimal? INSPNUM { get; set; }

        [StringLength(10)]
        public string INSPUNIT { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSGW { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSNW { get; set; }

        public decimal? ASSITPACKAGENUM { get; set; }

        [StringLength(10)]
        public string ASSITPACKAGETYPE { get; set; }

        [StringLength(50)]
        public string MATERIALSTYPE { get; set; }

        [StringLength(100)]
        public string PROCESSINGFACTORY { get; set; }

        [Column(TypeName = "float")]
        public decimal? ASSITGOODSLENGTH { get; set; }

        [Column(TypeName = "float")]
        public decimal? ASSITGOODSWIDTH { get; set; }

        [Column(TypeName = "float")]
        public decimal? ASSITGOODSHIGH { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(50)]
        public string PREINSPCODE { get; set; }

        [Column(TypeName = "float")]
        public decimal? STANDARD { get; set; }

        [StringLength(20)]
        public string STANDARDUNIT { get; set; }

        [StringLength(50)]
        public string PRODUCTIONBATCH { get; set; }

        [StringLength(50)]
        public string UNITYCODE { get; set; }

        public decimal? NEWNO { get; set; }

        public decimal? ISSPECIAL { get; set; }
    }
}
