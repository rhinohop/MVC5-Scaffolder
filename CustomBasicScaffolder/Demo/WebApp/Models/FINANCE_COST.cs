namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FINANCE_COST")]
    public partial class FINANCE_COST
    {
        public decimal ID { get; set; }

        public decimal? ORDERID { get; set; }

        public decimal? SETTLEMENTRULESID { get; set; }

        [StringLength(30)]
        public string SUPPLIERNAMEID { get; set; }

        [StringLength(200)]
        public string SUPPLIERNAME { get; set; }

        [StringLength(30)]
        public string COSTNAMEID { get; set; }

        [StringLength(50)]
        public string COSTNAME { get; set; }

        [Column(TypeName = "float")]
        public decimal? COST { get; set; }

        [StringLength(50)]
        public string CURRENCY { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? TYPE { get; set; }
    }
}
