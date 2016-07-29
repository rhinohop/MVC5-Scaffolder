namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_INSPWRITE")]
    public partial class TASK_INSPWRITE
    {
        public decimal ID { get; set; }

        [StringLength(25)]
        public string CODE { get; set; }

        [StringLength(25)]
        public string CUSTOMER { get; set; }

        [StringLength(50)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(25)]
        public string DECLTYPE { get; set; }

        [StringLength(50)]
        public string DECLTYPENAME { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? SENDTIME { get; set; }

        public DateTime? FINISHTIME { get; set; }

        public decimal? CHECKSTATUS { get; set; }

        [StringLength(50)]
        public string BUSIPLACE { get; set; }

        [StringLength(50)]
        public string PREDECLCODE { get; set; }

        [StringLength(50)]
        public string BUSIUNIT { get; set; }

        [StringLength(50)]
        public string BUSIUNITNAME { get; set; }

        [StringLength(50)]
        public string BUSITYPE { get; set; }

        [StringLength(50)]
        public string BUSITYPENAME { get; set; }

        [StringLength(10)]
        public string ISFORCELAW { get; set; }

        [StringLength(10)]
        public string ISNEEDCLEARANCE { get; set; }

        [StringLength(10)]
        public string INOUT { get; set; }

        [StringLength(10)]
        public string ISDECLARE { get; set; }

        [StringLength(5)]
        public string WMTRO { get; set; }

        [StringLength(5)]
        public string WMTMO { get; set; }

        [StringLength(5)]
        public string WMTINSP { get; set; }

        [StringLength(5)]
        public string WMT3 { get; set; }

        [StringLength(5)]
        public string GETRECEIPTSTATUS { get; set; }

        [StringLength(5)]
        public string GETCLEARANCESTATUS { get; set; }

        [StringLength(5)]
        public string GETHZDHPDF { get; set; }

        [StringLength(5)]
        public string GETINSPPDF { get; set; }

        [StringLength(50)]
        public string JOBNO { get; set; }

        [StringLength(50)]
        public string HZDH { get; set; }

        [StringLength(50)]
        public string INSPECTIONCODE { get; set; }

        [StringLength(500)]
        public string SYSINFO { get; set; }

        [StringLength(5)]
        public string INSPSTATUS { get; set; }

        public decimal? REPUSERID { get; set; }

        [StringLength(50)]
        public string REPUSERNAME { get; set; }

        [StringLength(50)]
        public string CLEARANCECODE { get; set; }

        [StringLength(5)]
        public string BAYONET { get; set; }

        [StringLength(5)]
        public string ARRIVALNO { get; set; }

        [StringLength(5)]
        public string DECLNOBACK { get; set; }

        [StringLength(5)]
        public string BAYNOBACK { get; set; }

        public DateTime? WMTROTIME { get; set; }

        public DateTime? WMTMOTIME { get; set; }

        public DateTime? WMTINSPTIME { get; set; }

        public DateTime? WMT3TIME { get; set; }

        public DateTime? GETRECEIPTSTATUSTIME { get; set; }

        public DateTime? GETCLEARANCESTATUSTIME { get; set; }

        public DateTime? GETHZDHPDFTIME { get; set; }

        public DateTime? GETINSPPDFTIME { get; set; }

        public DateTime? BAYONETTIME { get; set; }

        public DateTime? ARRIVALNOTIME { get; set; }

        public DateTime? DECLNOBACKTIME { get; set; }

        public DateTime? BAYNOBACKTIME { get; set; }

        public DateTime? INSPSTATUSTIME { get; set; }

        [StringLength(50)]
        public string REPWAYID { get; set; }
    }
}
