namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_TIMES")]
    public partial class LIST_TIMES
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string REALNAME { get; set; }

        public DateTime? TIMES { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(500)]
        public string REASON { get; set; }

        public decimal? ISPAUSE { get; set; }
    }
}
