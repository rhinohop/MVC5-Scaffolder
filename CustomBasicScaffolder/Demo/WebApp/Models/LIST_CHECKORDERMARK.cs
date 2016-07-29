namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_CHECKORDERMARK")]
    public partial class LIST_CHECKORDERMARK
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string PRECODE { get; set; }

        [StringLength(255)]
        public string CONTROLNAME { get; set; }

        public decimal? ENABLED { get; set; }
    }
}
