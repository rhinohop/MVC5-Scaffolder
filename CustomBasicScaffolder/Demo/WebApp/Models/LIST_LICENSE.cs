namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_LICENSE")]
    public partial class LIST_LICENSE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PCODE { get; set; }

        [StringLength(50)]
        public string LCODE { get; set; }

        [StringLength(50)]
        public string LNAME { get; set; }

        [StringLength(50)]
        public string LNO { get; set; }

        public decimal? SELECTED { get; set; }
    }
}
