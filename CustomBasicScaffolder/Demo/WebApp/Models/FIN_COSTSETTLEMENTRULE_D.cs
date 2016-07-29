namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FIN_COSTSETTLEMENTRULE_D")]
    public partial class FIN_COSTSETTLEMENTRULE_D
    {
        [Key]
        public decimal SEQ { get; set; }

        [StringLength(30)]
        public string SERVICEITEMSID { get; set; }

        [StringLength(50)]
        public string SERVICEITEMS { get; set; }

        [StringLength(30)]
        public string COSTNAMEID { get; set; }

        [StringLength(50)]
        public string COSTNAME { get; set; }

        [StringLength(30)]
        public string SUPPLIERNAMEID { get; set; }

        [StringLength(200)]
        public string SUPPLIERNAME { get; set; }

        [StringLength(30)]
        public string RULEEXECUTIONFIELDID { get; set; }

        [StringLength(200)]
        public string RULEEXECUTIONFIELD { get; set; }

        public decimal? ENABLEFLAG { get; set; }

        public DateTime? ENABLESTARTTIME { get; set; }

        public DateTime? ENABLEENDTIME { get; set; }

        public decimal? CREATEMAN { get; set; }

        [StringLength(100)]
        public string CREATEMANNAME { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? AUDITPERSONID { get; set; }

        [StringLength(50)]
        public string AUDITPERSON { get; set; }

        public DateTime? AUDITPERSONDATE { get; set; }

        public decimal? DISABLEPERSONID { get; set; }

        [StringLength(50)]
        public string DISABLEPERSON { get; set; }

        public DateTime? DISABLEDATE { get; set; }

        [StringLength(400)]
        public string DISABLEREASON { get; set; }

        [StringLength(400)]
        public string REMARK { get; set; }

        [StringLength(1000)]
        public string EXEXSQL { get; set; }

        public decimal? COSTSETTLEMENTID { get; set; }

        public decimal? STOPMAN { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(100)]
        public string CALCULATIONCONDITION { get; set; }

        [StringLength(30)]
        public string CALCULATIONCONDITIONID { get; set; }

        [StringLength(100)]
        public string CALCULATIONFORMULA { get; set; }

        [StringLength(30)]
        public string CALCULATIONFORMULAID { get; set; }

        public decimal? UNITPRICE { get; set; }

        [StringLength(100)]
        public string CURRENCY { get; set; }

        [StringLength(30)]
        public string CURRENCYID { get; set; }

        public decimal? MIN { get; set; }

        public decimal? MAX { get; set; }

        [StringLength(100)]
        public string EXECUTIONFIELD { get; set; }

        [StringLength(30)]
        public string EXECUTIONFIELDID { get; set; }

        public decimal? QYJZ { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(10)]
        public string ISRATE { get; set; }

        [Column(TypeName = "float")]
        public decimal? RATE { get; set; }

        [StringLength(20)]
        public string RULEID { get; set; }
    }
}
