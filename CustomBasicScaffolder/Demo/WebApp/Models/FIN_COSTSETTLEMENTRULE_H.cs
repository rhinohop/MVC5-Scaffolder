namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FIN_COSTSETTLEMENTRULE_H")]
    public partial class FIN_COSTSETTLEMENTRULE_H
    {
        [Key]
        [StringLength(30)]
        public string RULEID { get; set; }

        [StringLength(100)]
        public string RULENAME { get; set; }

        [StringLength(30)]
        public string COMPANYID { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? CREATEMANID { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(100)]
        public string STOPMANID { get; set; }

        [StringLength(100)]
        public string CUSTOMSID { get; set; }
    }
}
