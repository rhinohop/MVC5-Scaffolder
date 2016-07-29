namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.WEB_NOTICE")]
    public partial class WEB_NOTICE
    {
        [StringLength(36)]
        public string ID { get; set; }

        [StringLength(200)]
        public string TITLE { get; set; }

        public string CONTENT { get; set; }

        public decimal? CREATEID { get; set; }

        [StringLength(100)]
        public string CREATENAME { get; set; }

        public decimal? AUDITID { get; set; }

        [StringLength(100)]
        public string AUDITNAME { get; set; }

        [StringLength(50)]
        public string STATE { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [StringLength(200)]
        public string ATTACHMENT { get; set; }

        public DateTime? RELEASETIME { get; set; }

        public DateTime? CREATETIME { get; set; }
    }
}
