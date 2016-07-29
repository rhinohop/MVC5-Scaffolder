namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PAUSEOK")]
    public partial class LIST_PAUSEOK
    {
        public decimal ID { get; set; }

        public decimal? PID { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public decimal? ISOK { get; set; }

        public DateTime? TIMES { get; set; }

        public decimal? POST { get; set; }
    }
}
