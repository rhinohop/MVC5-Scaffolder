namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_DECLARATION_AFTER")]
    public partial class LIST_DECLARATION_AFTER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

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

        public decimal? ISFORCELAW { get; set; }

        public decimal? ISCOMFORCELAW { get; set; }

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
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string CUSTOMDISTRICTCODE { get; set; }

        [StringLength(50)]
        public string DECLTYPE { get; set; }

        public decimal? DECLSTATUS { get; set; }

        [StringLength(50)]
        public string PORTCODE { get; set; }

        [StringLength(50)]
        public string RECORDCODE { get; set; }

        [StringLength(50)]
        public string MATERIALSNUM { get; set; }

        [StringLength(50)]
        public string FINISHEDPRODUCTS { get; set; }

        [StringLength(2)]
        public string FORMATAUTO { get; set; }

        [StringLength(50)]
        public string CONTRACTNO { get; set; }

        public DateTime? INOUTDATE { get; set; }

        [StringLength(50)]
        public string BUSIUNITCODE { get; set; }

        [StringLength(50)]
        public string BUSIUNITTYPE { get; set; }

        [StringLength(50)]
        public string TRANSMODEL { get; set; }

        [StringLength(50)]
        public string TRANSNAME { get; set; }

        [StringLength(50)]
        public string CONSIGNEESHIPPER { get; set; }

        [StringLength(50)]
        public string VOYAGENO { get; set; }

        [StringLength(50)]
        public string BLNO { get; set; }

        [StringLength(50)]
        public string REPUNITCODE { get; set; }

        [StringLength(50)]
        public string TRADEMETHOD { get; set; }

        [StringLength(50)]
        public string KINDOFTAX { get; set; }

        [StringLength(50)]
        public string TAXATIONRATE { get; set; }

        [StringLength(50)]
        public string LICENSENO { get; set; }

        [StringLength(50)]
        public string STARTENDCOUNTRY { get; set; }

        [StringLength(50)]
        public string STARTENDPORT { get; set; }

        [StringLength(50)]
        public string STARTENDPLACE { get; set; }

        [StringLength(50)]
        public string TAXUNITCODE { get; set; }

        [StringLength(50)]
        public string PACKAGETYPE { get; set; }

        [StringLength(50)]
        public string TRADETERMS { get; set; }

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

        [StringLength(255)]
        public string REMARKNO { get; set; }

        [StringLength(50)]
        public string PREDECLNO { get; set; }

        [StringLength(50)]
        public string WAREHOUSENO { get; set; }

        [StringLength(50)]
        public string CONTAINERNO { get; set; }

        [StringLength(50)]
        public string ATTACHEDDOCUMENTS { get; set; }

        [StringLength(50)]
        public string YARDCODE { get; set; }

        [StringLength(500)]
        public string DECLREMARK { get; set; }

        [StringLength(50)]
        public string LISTTYPE { get; set; }

        [StringLength(50)]
        public string LISTTYPEDE { get; set; }

        [StringLength(50)]
        public string LISTNO { get; set; }

        [StringLength(50)]
        public string LISTNODE { get; set; }

        public decimal? DECLARANT { get; set; }

        [StringLength(50)]
        public string MINIREGUNO { get; set; }

        [StringLength(50)]
        public string COMPREGUNO { get; set; }

        [StringLength(500)]
        public string CSREMARK { get; set; }

        public decimal? CSID { get; set; }

        public decimal? MOID { get; set; }

        public decimal? COID { get; set; }

        public DateTime? DISTRIBUTETIME { get; set; }

        public DateTime? MOACCEPTTIME { get; set; }

        public decimal? CLEARANCETYPE { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(50)]
        public string MANUFACTURERORUSE { get; set; }

        [StringLength(50)]
        public string COMPANYNATURE { get; set; }

        [StringLength(200)]
        public string CONSIGNEESHIPPERNAME { get; set; }

        [StringLength(50)]
        public string DECLKIND { get; set; }

        public DateTime? MOSTARTTIME { get; set; }

        public decimal? MOTIME { get; set; }

        public DateTime? CSSTARTTIME { get; set; }

        public decimal? CSTIME { get; set; }

        public decimal? PAGENO { get; set; }

        public decimal? BACKSTATUS { get; set; }

        public DateTime? MOENDTIME { get; set; }

        [StringLength(50)]
        public string PORTNAME { get; set; }

        [StringLength(50)]
        public string CUSTOMDISTRICTNAME { get; set; }

        [StringLength(50)]
        public string STARTENDPLACENAME { get; set; }

        [StringLength(50)]
        public string STARTENDPORTNAME { get; set; }

        [StringLength(50)]
        public string BUSIUNITNAME { get; set; }

        [StringLength(50)]
        public string REPUNITNAME { get; set; }

        [StringLength(50)]
        public string DECLARATIONCODE { get; set; }

        [StringLength(50)]
        public string STARTENDCOUNTRYNAME { get; set; }

        public DateTime? INDATE { get; set; }

        [StringLength(50)]
        public string INOUTTYPE { get; set; }

        [StringLength(50)]
        public string OPERTOR { get; set; }

        [StringLength(50)]
        public string ZCTY_NO { get; set; }

        [StringLength(50)]
        public string XZLB { get; set; }

        public decimal? SPECIALRELATIONSHIP { get; set; }

        public decimal? PRICEIMPACT { get; set; }

        public decimal? PAYPOYALTIES { get; set; }

        [StringLength(50)]
        public string TRADECOUNTRYCODE { get; set; }

        [StringLength(50)]
        public string TRADECOUNTRYNAME { get; set; }

        [StringLength(50)]
        public string BUSISOCIALCREDITNO { get; set; }

        [StringLength(50)]
        public string CUSTOMSOCIALCREDITNO { get; set; }

        [StringLength(50)]
        public string SCSOCIALCREDITNO { get; set; }
    }
}
