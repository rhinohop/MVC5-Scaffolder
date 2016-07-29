namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.USER_USE_DECLARATIONCAR")]
    public partial class USER_USE_DECLARATIONCAR
    {
        public decimal ID { get; set; }

        public decimal USERCOMPANYID { get; set; }

        public decimal DECLARATIONCARID { get; set; }

        [Required]
        [StringLength(50)]
        public string MOTORCADE { get; set; }

        public decimal? USERID { get; set; }

        public DateTime? CREATEDATE { get; set; }
    }
}
