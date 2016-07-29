namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_DECLARATION")]
    public partial class LIST_DECLARATION
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string PREDECLCODE { get; set; }

        [StringLength(50)]
        public string DECLARATIONCODE { get; set; }

        [StringLength(50)]
        public string UNITYCODE { get; set; }

        public decimal? GOODSNUM { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSGW { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSNW { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(50)]
        public string CURRENTCODE { get; set; }

        public DateTime? STARTTIME { get; set; }

        public DateTime? ENDTIME { get; set; }

        public decimal? COTIME { get; set; }

        public decimal? ISPAUSE { get; set; }

        public decimal? ISFORCELAW { get; set; }

        public decimal? ISCOMFORCELAW { get; set; }

        public decimal? ISINVALID { get; set; }

        public decimal? DOWNLOADSTATUS { get; set; }

        public decimal? VALIDATESTATUS { get; set; }

        public DateTime? REPTIME { get; set; }

        public decimal? PREACCEPTUSERID { get; set; }

        public DateTime? PREACCEPTTIME { get; set; }

        public DateTime? REPFINISHTIME { get; set; }

        [StringLength(50)]
        public string PRECHANNEL { get; set; }

        [StringLength(50)]
        public string PREMODEL { get; set; }

        public decimal? REPUSERID { get; set; }

        [StringLength(50)]
        public string REPUSERNAME { get; set; }

        public decimal? REPFINISHUSERID { get; set; }

        [StringLength(50)]
        public string REPFINISHUSERNAME { get; set; }

        [StringLength(500)]
        public string VALIDATEREASON { get; set; }

        [StringLength(50)]
        public string PREACCEPTUSERNAME { get; set; }

        [StringLength(50)]
        public string DECLUSERID { get; set; }

        public decimal? PRIORITY { get; set; }

        public DateTime? PRESTARTTIME { get; set; }

        public DateTime? PREENDTIME { get; set; }

        public decimal? PRETIME { get; set; }

        public decimal? PREID { get; set; }

        [StringLength(25)]
        public string PRENAME { get; set; }

        public decimal? NUMS { get; set; }

        [StringLength(50)]
        public string LICENSENO { get; set; }

        [StringLength(50)]
        public string FREIGHTCODE { get; set; }

        [StringLength(50)]
        public string FREIGHT { get; set; }

        [StringLength(50)]
        public string FREIGHTCURRENCY { get; set; }

        [StringLength(50)]
        public string IPCODE { get; set; }

        [StringLength(50)]
        public string INSURANCEPREMIUM { get; set; }

        [StringLength(50)]
        public string IPCURRENCY { get; set; }

        [StringLength(50)]
        public string AECODE { get; set; }

        [StringLength(50)]
        public string ADDITIONALEXPENSES { get; set; }

        [StringLength(50)]
        public string AECURRENCY { get; set; }

        [StringLength(50)]
        public string APPROVALNO { get; set; }

        [StringLength(50)]
        public string ATTACHEDDOCUMENTS { get; set; }

        [StringLength(500)]
        public string DECLREMARK { get; set; }

        public decimal? PAUSENUM { get; set; }

        [StringLength(50)]
        public string CONTRACTNO { get; set; }

        public decimal? ISBACK { get; set; }

        [StringLength(20)]
        public string BUSITYPE { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string DECLCHANNEL { get; set; }

        public decimal? ELEBACK { get; set; }

        public DateTime? SUBMITTIME { get; set; }

        public DateTime? CKACCEPTTIME { get; set; }

        public decimal? CKACCEPTUSERID { get; set; }

        [StringLength(50)]
        public string CKACCEPTUSERNAME { get; set; }

        public decimal? CKISACCEPT { get; set; }

        public DateTime? PICHECKTIMEOK { get; set; }

        public decimal? PREDECLFLAG { get; set; }

        public decimal? DECLPDFFLAG { get; set; }

        public decimal? PREPAUSENUM { get; set; }

        public decimal? PREISPAUSE { get; set; }

        public decimal? EXTRASTATUS { get; set; }

        public DateTime? CKTIME { get; set; }

        public decimal? CKID { get; set; }

        [StringLength(50)]
        public string CKNAME { get; set; }

        public decimal? RESENDNUM { get; set; }

        [StringLength(500)]
        public string CSREMARK { get; set; }

        [StringLength(500)]
        public string CUSTOMERREMARK { get; set; }

        public decimal? SHEETNUM { get; set; }

        public decimal? ISPRINT { get; set; }

        public DateTime? PRINTTIME { get; set; }

        public decimal? PRINTNUM { get; set; }

        public decimal? ISNEEDCLEARANCE { get; set; }

        public decimal? ISHAVECLEARANCE { get; set; }

        [StringLength(50)]
        public string JOBNO { get; set; }

        [StringLength(5)]
        public string ISBACK28 { get; set; }

        public DateTime? RELATEDTIME { get; set; }

        public decimal? RELATEDUSERID { get; set; }

        [StringLength(50)]
        public string RELATEDUSERNAME { get; set; }

        public DateTime? REPOVERTIME { get; set; }

        public decimal? COSUBMITUSERID { get; set; }

        [StringLength(50)]
        public string COSUBMITUSERNAME { get; set; }

        public decimal? COID { get; set; }

        [StringLength(50)]
        public string CONAME { get; set; }

        [StringLength(50)]
        public string CUSTOMSSTATUS { get; set; }

        public decimal? PRINTUSERID { get; set; }

        [StringLength(50)]
        public string PRINTUSERNAME { get; set; }

        [StringLength(50)]
        public string SOCIALCREDITNO { get; set; }

        public decimal? SPECIALRELATIONSHIP { get; set; }

        public decimal? PRICEIMPACT { get; set; }

        public decimal? PAYPOYALTIES { get; set; }

        public decimal? PRESHEETNUM { get; set; }

        [StringLength(50)]
        public string TRANSNAME { get; set; }

        [StringLength(255)]
        public string REMARKNO { get; set; }

        [StringLength(255)]
        public string PREDECLNO { get; set; }
    }
}
