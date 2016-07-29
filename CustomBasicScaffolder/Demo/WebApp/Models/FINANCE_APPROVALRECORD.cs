namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FINANCE_APPROVALRECORD")]
    public partial class FINANCE_APPROVALRECORD
    {
        public decimal ID { get; set; }

        public decimal? ORDERID { get; set; }

        public decimal? COSTNAMEID { get; set; }

        public decimal? ALTERMAN { get; set; }

        public DateTime? ALTERDATE { get; set; }

        [StringLength(300)]
        public string REASON { get; set; }

        [StringLength(500)]
        public string CONTENTES { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? FIRSTMAN { get; set; }

        public decimal? SECONDMAN { get; set; }

        public decimal? REVOKEMAN { get; set; }

        public decimal? APPLICANT { get; set; }
    }
}
