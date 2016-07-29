namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_ORDERRECORDER")]
    public partial class LIST_ORDERRECORDER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        public decimal? USERID { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? TIMES { get; set; }
    }
}
