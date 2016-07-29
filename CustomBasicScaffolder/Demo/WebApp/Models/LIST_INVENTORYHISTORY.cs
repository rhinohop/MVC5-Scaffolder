namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_INVENTORYHISTORY")]
    public partial class LIST_INVENTORYHISTORY
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public DateTime? TIMES { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(50)]
        public string PREDECLCODE { get; set; }

        public decimal? ISDISTRIBUTE { get; set; }

        public DateTime? ACCEPTTIME { get; set; }

        public decimal? ACCEPTUSER { get; set; }

        public DateTime? ASSOCIATETIME { get; set; }

        public decimal? ASSOCIATEUSER { get; set; }

        public decimal? INVALIDUSER { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        public DateTime? INVALIDTIME { get; set; }

        [StringLength(200)]
        public string REASON { get; set; }
    }
}
