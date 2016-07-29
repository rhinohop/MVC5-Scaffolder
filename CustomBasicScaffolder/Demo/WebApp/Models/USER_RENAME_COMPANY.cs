namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.USER_RENAME_COMPANY")]
    public partial class USER_RENAME_COMPANY
    {
        public decimal ID { get; set; }

        public decimal? USERID { get; set; }

        public decimal COMPANYID { get; set; }

        [StringLength(100)]
        public string COMPANYCHNAME { get; set; }

        [StringLength(100)]
        public string COMPANYENNAME { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? CUSTOMERID { get; set; }
    }
}
