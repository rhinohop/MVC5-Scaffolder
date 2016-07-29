namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.RELA_CONTAINER")]
    public partial class RELA_CONTAINER
    {
        public decimal ID { get; set; }

        [StringLength(20)]
        public string CONTAINERSIZE { get; set; }

        [StringLength(20)]
        public string CONTAINERTYPE { get; set; }

        [StringLength(20)]
        public string FORMATCODE { get; set; }

        [StringLength(20)]
        public string FORMATNAME { get; set; }

        [StringLength(20)]
        public string CONTAINERHS { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
