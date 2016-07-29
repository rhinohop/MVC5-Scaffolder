namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_RECORDINFO_DETAIL")]
    public partial class SYS_RECORDINFO_DETAIL
    {
        public decimal ID { get; set; }

        public decimal? RECORDINFOID { get; set; }

        public decimal? ITEMNO { get; set; }

        [StringLength(50)]
        public string HSCODE { get; set; }

        [StringLength(50)]
        public string ADDITIONALNO { get; set; }

        [StringLength(50)]
        public string ITEMNOATTRIBUTE { get; set; }

        [StringLength(100)]
        public string COMMODITYNAME { get; set; }

        [StringLength(200)]
        public string SPECIFICATIONSMODEL { get; set; }

        [StringLength(20)]
        public string UNIT { get; set; }

        [StringLength(20)]
        public string VERSION { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public decimal? ABNORMAL { get; set; }
    }
}
