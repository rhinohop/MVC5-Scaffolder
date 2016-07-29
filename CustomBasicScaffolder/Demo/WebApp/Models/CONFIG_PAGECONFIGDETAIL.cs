namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONFIG_PAGECONFIGDETAIL")]
    public partial class CONFIG_PAGECONFIGDETAIL
    {
        public decimal ID { get; set; }

        public decimal? PAGECONFIGID { get; set; }

        [StringLength(50)]
        public string LOGIC { get; set; }

        [StringLength(50)]
        public string OPERATORSYMBOL { get; set; }

        [StringLength(50)]
        public string PAGEFILED { get; set; }

        [StringLength(50)]
        public string PAGEFILEDNUM { get; set; }

        [StringLength(50)]
        public string FILEDTYPE { get; set; }

        [StringLength(500)]
        public string FILEDVALUE { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public decimal? TYPE { get; set; }
    }
}
