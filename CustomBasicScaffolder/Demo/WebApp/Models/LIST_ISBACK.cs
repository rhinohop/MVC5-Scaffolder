namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_ISBACK")]
    public partial class LIST_ISBACK
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string USERCODE { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? TYPE { get; set; }
    }
}
