namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_TRMAPPING")]
    public partial class SYS_TRMAPPING
    {
        public decimal ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TABLENAME { get; set; }

        public decimal ACTIVE { get; set; }

        public decimal PREINSERTFLAG { get; set; }

        public decimal POSTINSERTFLAG { get; set; }

        public decimal PREUPDATEFLAG { get; set; }

        public decimal POSTUPDATEFLAG { get; set; }

        public decimal PREDELETEFLAG { get; set; }

        public decimal POSTDELETEFLAG { get; set; }

        [StringLength(1000)]
        public string DLLNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string CLASSNAME { get; set; }

        [Required]
        [StringLength(1000)]
        public string PACKAGE { get; set; }

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
