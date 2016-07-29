namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_RESENDHISTORY")]
    public partial class LIST_RESENDHISTORY
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string CHANNEL { get; set; }

        public DateTime? TIMES { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public decimal? TYPE { get; set; }

        [StringLength(50)]
        public string SENDTYPE { get; set; }

        public decimal? RESENDNUM { get; set; }

        [StringLength(50)]
        public string EDOCFILENAME { get; set; }
    }
}
