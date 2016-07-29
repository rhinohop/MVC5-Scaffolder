namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FIN_ACCOUNTSRECEIVABLE")]
    public partial class FIN_ACCOUNTSRECEIVABLE
    {
        public decimal ID { get; set; }

        [StringLength(100)]
        public string COSTCATEGORY { get; set; }

        [StringLength(36)]
        public string COSTCATEGORYID { get; set; }

        [StringLength(100)]
        public string COSTNAME { get; set; }

        [StringLength(36)]
        public string COSTNAMEID { get; set; }

        [StringLength(100)]
        public string BILLINGFEENAME { get; set; }

        [StringLength(200)]
        public string SETTLEMENTUNIT { get; set; }

        [StringLength(36)]
        public string SETTLEMENTUNITID { get; set; }

        public decimal? CHARGEQUANTITY { get; set; }

        [Column(TypeName = "float")]
        public decimal? UNITPRICE { get; set; }

        [Column(TypeName = "float")]
        public decimal? TOTAL { get; set; }

        [StringLength(100)]
        public string CURRENCY { get; set; }

        [StringLength(36)]
        public string CURRENCYID { get; set; }

        public decimal? TAXPRICE { get; set; }

        [Column(TypeName = "float")]
        public decimal? TAXRATE { get; set; }

        [Column(TypeName = "float")]
        public decimal? AMOUNTCREDITED { get; set; }

        [Column(TypeName = "float")]
        public decimal? OUTPUTTAX { get; set; }

        [Column(TypeName = "float")]
        public decimal? INVOICEAMOUNT { get; set; }

        [StringLength(50)]
        public string FIRSTINSTANCENUMBER { get; set; }

        [StringLength(50)]
        public string SECONDINSTANCENUMBER { get; set; }

        [StringLength(50)]
        public string CHECKNUMBER { get; set; }

        [StringLength(50)]
        public string ISSUENUMBER { get; set; }

        [StringLength(50)]
        public string INVOICENUMBER { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public decimal? FIRSTINSTANCEMARK { get; set; }

        public decimal? SECONDINSTANCEMARK { get; set; }

        public decimal? SIGNRECONCILIATION { get; set; }

        public decimal? BILLRELEASE { get; set; }

        public decimal? BILLINGSIGN { get; set; }

        public decimal? WRITEOFFMARK { get; set; }

        public decimal? ORDERID { get; set; }

        [StringLength(36)]
        public string BILLINGFEENAMEID { get; set; }

        public decimal? AUDITSTATUS { get; set; }

        public decimal? INVALID { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(1)]
        public string ISAUTOINSERT { get; set; }
    }
}
