namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_FILECONFIG")]
    public partial class LIST_FILECONFIG
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        public decimal? FILETYPEID { get; set; }

        public decimal? FILENUM { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? UPFILENUM { get; set; }
    }
}
