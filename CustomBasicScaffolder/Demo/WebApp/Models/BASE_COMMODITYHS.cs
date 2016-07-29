namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_COMMODITYHS")]
    public partial class BASE_COMMODITYHS
    {
        public decimal ID { get; set; }

        [StringLength(250)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string HSCODE { get; set; }

        [StringLength(50)]
        public string EXTRACODE { get; set; }

        [StringLength(50)]
        public string LEGALUNIT { get; set; }

        [StringLength(50)]
        public string SECONDUNIT { get; set; }

        [StringLength(50)]
        public string CIQCODE { get; set; }

        [StringLength(50)]
        public string CUSTOMREGULATORY { get; set; }

        [StringLength(50)]
        public string INSPECTIONREGULATORY { get; set; }

        [StringLength(50)]
        public string CLASSCODE { get; set; }

        [StringLength(50)]
        public string AGREETAXFILE { get; set; }

        [StringLength(50)]
        public string TOPPRICE { get; set; }

        [StringLength(50)]
        public string LOWPRICE { get; set; }

        [StringLength(200)]
        public string GENERALRATE { get; set; }

        [StringLength(200)]
        public string FAVORABLERATE { get; set; }

        [StringLength(50)]
        public string VATRATE { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? YEARID { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string EXPORTREBATRATE { get; set; }

        [StringLength(200)]
        public string TEMPRATE { get; set; }

        [StringLength(200)]
        public string CONSUMERATE { get; set; }

        [StringLength(200)]
        public string EXPORTRATE { get; set; }

        [StringLength(500)]
        public string ELEMENTS { get; set; }

        [StringLength(10)]
        public string SPECIALMARK { get; set; }
    }
}
