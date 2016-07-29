namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_ATTACHMENT")]
    public partial class LIST_ATTACHMENT
    {
        public decimal ID { get; set; }

        [StringLength(255)]
        public string FILENAME { get; set; }

        [StringLength(255)]
        public string ORIGINALNAME { get; set; }

        public DateTime? UPLOADTIME { get; set; }

        public decimal? UPLOADUSERID { get; set; }

        public decimal? FILETYPE { get; set; }

        [StringLength(50)]
        public string CUSTOMERCODE { get; set; }

        public decimal? SIZES { get; set; }

        public decimal? CONFIRMSTATUS { get; set; }

        public decimal? CONFIRMER { get; set; }

        public DateTime? CONFIRMTIME { get; set; }

        public decimal? ABOLISHSTATUS { get; set; }

        public DateTime? ABOLISHTIME { get; set; }

        [StringLength(255)]
        public string ABOLISHREASON { get; set; }

        public decimal? ABOLISHER { get; set; }

        public decimal? ORIGINALFLAG { get; set; }

        [StringLength(500)]
        public string ORDERCODE { get; set; }

        [StringLength(20)]
        public string FILESUFFIX { get; set; }

        [StringLength(100)]
        public string FILETYPENAME { get; set; }

        [StringLength(500)]
        public string FILEGUID { get; set; }

        public decimal? SPLITSTATUS { get; set; }

        [StringLength(50)]
        public string DECLCODE { get; set; }

        [StringLength(50)]
        public string INSPCODE { get; set; }

        [StringLength(50)]
        public string IETYPE { get; set; }

        [StringLength(50)]
        public string PREDECLCODE { get; set; }

        [StringLength(50)]
        public string ISUPLOAD { get; set; }

        public decimal? PGINDEX { get; set; }

        public decimal? ORDERCOUNT { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(50)]
        public string UPLOADUSERNAME { get; set; }
    }
}
