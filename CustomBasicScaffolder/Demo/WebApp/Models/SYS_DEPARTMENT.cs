namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_DEPARTMENT")]
    public partial class SYS_DEPARTMENT
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public decimal? COMPANYID { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(36)]
        public string PARENTID { get; set; }

        public bool? ISLEAF { get; set; }

        public decimal? SORTINDEX { get; set; }

        [StringLength(1000)]
        public string PATH { get; set; }

        [StringLength(200)]
        public string COMPANYNAME { get; set; }

        [StringLength(1000)]
        public string FULLNAME { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        public decimal? POSITIONID { get; set; }

        [StringLength(500)]
        public string POSITIONNAME { get; set; }
    }
}
