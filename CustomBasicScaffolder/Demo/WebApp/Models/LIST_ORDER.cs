namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_ORDER")]
    public partial class LIST_ORDER
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIST_ORDER()
        {
            CHATTOPICs = new HashSet<CHATTOPIC>();
        }

        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string BUSITYPE { get; set; }

        [StringLength(50)]
        public string CUSNO { get; set; }

        [StringLength(50)]
        public string BUSIUNITCODE { get; set; }

        [StringLength(50)]
        public string CONTRACTNO { get; set; }

        [StringLength(50)]
        public string TOTALNO { get; set; }

        [StringLength(50)]
        public string DIVIDENO { get; set; }

        [StringLength(50)]
        public string TURNPRENO { get; set; }

        [StringLength(50)]
        public string CLEARANCENO { get; set; }

        [StringLength(50)]
        public string WOODPACKINGID { get; set; }

        public decimal? LAWCONDITION { get; set; }

        public decimal? GOODSNUM { get; set; }

        public long? GOODSWEIGHT { get; set; }

        [StringLength(50)]
        public string REGNO { get; set; }

        [StringLength(50)]
        public string REPWAYID { get; set; }

        [StringLength(50)]
        public string CUSTOMDISTRICTCODE { get; set; }

        [StringLength(50)]
        public string PORTCODE { get; set; }

        [StringLength(50)]
        public string REPUNITCODE { get; set; }

        [StringLength(50)]
        public string INSPUNITCODE { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string CUSTOMERCODE { get; set; }

        public decimal? CREATEUSERID { get; set; }

        public DateTime? CREATETIME { get; set; }

        public decimal? SUBMITUSERID { get; set; }

        public DateTime? SUBMITTIME { get; set; }

        public decimal? CSACCEPTUSERID { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(500)]
        public string ENTRUSTREQUEST { get; set; }

        [StringLength(50)]
        public string ENTRUSTTYPEID { get; set; }

        [StringLength(255)]
        public string MANIFEST { get; set; }

        [StringLength(255)]
        public string SHIPNAME { get; set; }

        [StringLength(255)]
        public string FILGHTNO { get; set; }

        [StringLength(255)]
        public string LADINGBILLNO { get; set; }

        public decimal? PRIORITY { get; set; }

        [StringLength(255)]
        public string TRADEWAYCODES { get; set; }

        [StringLength(255)]
        public string DECLCARNO { get; set; }

        [StringLength(255)]
        public string CLEARUNIT { get; set; }

        [StringLength(50)]
        public string BUSIKIND { get; set; }

        [StringLength(50)]
        public string DECLWAY { get; set; }

        [StringLength(50)]
        public string ORDERWAY { get; set; }

        [StringLength(100)]
        public string PACKKIND { get; set; }

        public decimal? GOODSGW { get; set; }

        public decimal? GOODSNW { get; set; }

        [StringLength(100)]
        public string ARRIVEDNO { get; set; }

        [StringLength(100)]
        public string LANDREGNO { get; set; }

        [StringLength(500)]
        public string CSREQUEST { get; set; }

        [StringLength(500)]
        public string CLEARREMARK { get; set; }

        public decimal? CSID { get; set; }

        public DateTime? CSACCEPTTIME { get; set; }

        public DateTime? CSSUBMITTIME { get; set; }

        public decimal? MOID { get; set; }

        public DateTime? MOACCEPTTIME { get; set; }

        public decimal? COID { get; set; }

        public DateTime? COACCEPTTIME { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(255)]
        public string FIRSTLADINGBILLNO { get; set; }

        [StringLength(255)]
        public string SECONDLADINGBILLNO { get; set; }

        [StringLength(50)]
        public string GOODSTYPEID { get; set; }

        [StringLength(255)]
        public string CONTAINERNO { get; set; }

        public decimal? SECONDTRANSIT { get; set; }

        [StringLength(20)]
        public string ASSOCIATENO { get; set; }

        [StringLength(20)]
        public string CORRESPONDNO { get; set; }

        public decimal? EXTRASTATUS { get; set; }

        [StringLength(20)]
        public string INTERNALTYPE { get; set; }

        [StringLength(100)]
        public string ASSOCIATECUSTOMSNO { get; set; }

        [StringLength(200)]
        public string BUSIUNITNAME { get; set; }

        [StringLength(200)]
        public string REPUNITNAME { get; set; }

        [StringLength(200)]
        public string INSPUNITNAME { get; set; }

        [StringLength(200)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        [StringLength(50)]
        public string SUBMITUSERNAME { get; set; }

        [StringLength(50)]
        public string CSNAME { get; set; }

        [StringLength(50)]
        public string MONAME { get; set; }

        [StringLength(50)]
        public string CONAME { get; set; }

        [StringLength(200)]
        public string CLEARUNITNAME { get; set; }

        [StringLength(200)]
        public string FILINGNUMBER { get; set; }

        [StringLength(200)]
        public string ATTRIBUTION { get; set; }

        [StringLength(50)]
        public string TRADEWAYCODES1 { get; set; }

        public DateTime? CSSTARTTIME { get; set; }

        public decimal? CSTIME { get; set; }

        public decimal? SETNUM { get; set; }

        public decimal? PAPERNUM { get; set; }

        public decimal? MOACCEPTUSERID { get; set; }

        public decimal? COACCEPTUSERID { get; set; }

        [StringLength(200)]
        public string ASSOCIATEPEDECLNO { get; set; }

        public decimal? ISPAUSE { get; set; }

        [StringLength(50)]
        public string ASSOCIATETRADEWAY { get; set; }

        public decimal? DECLSTATUS { get; set; }

        public decimal? INSPSTATUS { get; set; }

        public decimal? DECLSETNUM { get; set; }

        public decimal? INSPSETNUM { get; set; }

        public decimal? DECLSHEETNUM { get; set; }

        public decimal? INSPSHEETNUM { get; set; }

        public decimal? PREDECLSETNUM { get; set; }

        public decimal? PREINSPSETNUM { get; set; }

        public DateTime? MOSTARTTIME { get; set; }

        public DateTime? MOENDTIME { get; set; }

        public decimal? MOTIME { get; set; }

        public DateTime? COSTARTTIME { get; set; }

        public DateTime? COENDTIME { get; set; }

        public decimal? COTIME { get; set; }

        public decimal? DECLPAUSE { get; set; }

        public decimal? INSPPAUSE { get; set; }

        [StringLength(50)]
        public string PORTNAME { get; set; }

        [StringLength(50)]
        public string CUSTOMDISTRICTNAME { get; set; }

        [StringLength(50)]
        public string SUBMITUSERPHONE { get; set; }

        [StringLength(50)]
        public string CSPHONE { get; set; }

        [StringLength(50)]
        public string YWBH { get; set; }

        public DateTime? FINISHTIME { get; set; }

        public decimal? COBACK { get; set; }

        public decimal? PAUSENUM { get; set; }

        [StringLength(50)]
        public string MOACCEPTUSERNAME { get; set; }

        [StringLength(50)]
        public string COACCEPTUSERNAME { get; set; }

        [StringLength(50)]
        public string CSACCEPTUSERNAME { get; set; }

        [StringLength(500)]
        public string INVALIDREASON { get; set; }

        [StringLength(50)]
        public string BUSISHORTNAME { get; set; }

        [StringLength(50)]
        public string BUSISHORTCODE { get; set; }

        public decimal? CSISBACK { get; set; }

        public decimal? MOISBACK { get; set; }

        public decimal? COISBACK { get; set; }

        [StringLength(10)]
        public string INOUTTYPE { get; set; }

        public DateTime? MOSUBMITTIME { get; set; }

        public DateTime? COSUBMITTIME { get; set; }

        [StringLength(50)]
        public string IETYPE { get; set; }

        public decimal? CSSUBMITUSERID { get; set; }

        [StringLength(50)]
        public string CSSUBMITUSERNAME { get; set; }

        public decimal? SPECIALRELATIONSHIP { get; set; }

        public decimal? PRICEIMPACT { get; set; }

        public decimal? PAYPOYALTIES { get; set; }

        public decimal? PREISPAUSE { get; set; }

        public decimal? SCENEDECLAREID { get; set; }

        public decimal? SCENEINSPECTID { get; set; }

        public decimal? DECLPDF { get; set; }

        public decimal? INSPPDF { get; set; }

        public decimal? CHECKPDF { get; set; }

        public decimal? PREPDF { get; set; }

        public decimal? ISTURNPRE { get; set; }

        public DateTime? DECLFINISHTIME { get; set; }

        public DateTime? INSPFINISHTIME { get; set; }

        public decimal? SPLITNUM { get; set; }

        public decimal? SELFCHECK { get; set; }

        public decimal? ISSELFCHECK { get; set; }

        public DateTime? SELFCHECKTIME { get; set; }

        [StringLength(50)]
        public string SELFCHECKUSERCODE { get; set; }

        [StringLength(50)]
        public string SELFCHECKUSERNAME { get; set; }

        public decimal? WEIGHTCHECK { get; set; }

        public decimal? ISWEIGHTCHECK { get; set; }

        public DateTime? WEIGHTCHECKTIME { get; set; }

        [StringLength(50)]
        public string WEIGHTCHECKUSERCODE { get; set; }

        [StringLength(50)]
        public string WEIGHTCHECKUSERNAME { get; set; }

        public decimal? CHECKEDGOODSNUM { get; set; }

       // [Column(TypeName = "float")]
        public decimal? CHECKEDWEIGHT { get; set; }

       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATTOPIC> CHATTOPICs { get; set; }
    }
}
