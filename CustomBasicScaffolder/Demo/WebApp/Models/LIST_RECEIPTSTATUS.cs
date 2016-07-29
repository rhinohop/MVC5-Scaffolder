namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_RECEIPTSTATUS")]
    public partial class LIST_RECEIPTSTATUS
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string CURRENTCODE { get; set; }

        [StringLength(50)]
        public string UNITYCODE { get; set; }

        [StringLength(50)]
        public string DECLCODE { get; set; }

        [StringLength(50)]
        public string STATUS { get; set; }

        public DateTime? TIMES { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(500)]
        public string ERRORMESSAGE { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(50)]
        public string DECLSTATUS { get; set; }
    }
}
