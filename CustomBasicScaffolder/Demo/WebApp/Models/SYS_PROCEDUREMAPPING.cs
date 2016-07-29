namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_PROCEDUREMAPPING")]
    public partial class SYS_PROCEDUREMAPPING
    {
        public decimal ID { get; set; }

        [Required]
        [StringLength(20)]
        public string PROCEDURENAME { get; set; }

        [StringLength(1000)]
        public string DLLNAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string PACKAGE { get; set; }

        [Required]
        [StringLength(100)]
        public string CLASSNAME { get; set; }

        public decimal TRANSACTION { get; set; }

        [StringLength(2000)]
        public string PARAMETER { get; set; }

        public decimal ACTIVE { get; set; }

        [Required]
        [StringLength(20)]
        public string CREATEMAN { get; set; }

        public DateTime CREATEDATE { get; set; }

        [Required]
        [StringLength(20)]
        public string EDITMAN { get; set; }

        public DateTime EDITDATE { get; set; }
    }
}
