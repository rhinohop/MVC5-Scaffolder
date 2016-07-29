namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BASE_STATUSCONFIG")]
    public partial class BASE_STATUSCONFIG
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string BUSISTATUS { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(255)]
        public string DESCRIPTION { get; set; }

        public decimal? ORDERNO { get; set; }
    }
}
