namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_ORDERATTACHMENT")]
    public partial class LIST_ORDERATTACHMENT
    {
        [Key]
        [StringLength(50)]
        public string ORDERCODE { get; set; }

        public decimal? ATTACHMENTSTATUS { get; set; }

        [StringLength(255)]
        public string SPLITEDETAIL { get; set; }

        public decimal? FILETYPEID { get; set; }

        [StringLength(200)]
        public string SUBTYPEID { get; set; }

        [StringLength(200)]
        public string SUBTYPENAME { get; set; }
    }
}
