namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_UPDATEHISTORY")]
    public partial class LIST_UPDATEHISTORY
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        public decimal? USERID { get; set; }

        public DateTime? UPDATETIME { get; set; }

        [StringLength(500)]
        public string OLDFIELD { get; set; }

        [StringLength(500)]
        public string NEWFIELD { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string FIELDNAME { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string FIELD { get; set; }
    }
}
