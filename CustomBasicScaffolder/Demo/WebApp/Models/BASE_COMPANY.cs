namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_COMPANY")]
    public partial class BASE_COMPANY
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string ENGLISHNAME { get; set; }

        [StringLength(50)]
        public string DECLNATURE { get; set; }

        [StringLength(50)]
        public string INSPCODE { get; set; }

        [StringLength(50)]
        public string INCODE { get; set; }

        [StringLength(50)]
        public string INSPNATURE { get; set; }

        [StringLength(50)]
        public string GOODSLOCAL { get; set; }

        [StringLength(50)]
        public string RECEIVERTYPE { get; set; }

        [StringLength(50)]
        public string SOCIALCREDITNO { get; set; }
    }
}
