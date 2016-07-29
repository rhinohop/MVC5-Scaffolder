namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CONTAINERS")]
    public partial class CONTAINER
    {
        [StringLength(20)]
        public string DJBM { get; set; }

        [StringLength(20)]
        public string JZXH { get; set; }

        [StringLength(20)]
        public string JZXGG { get; set; }

        [StringLength(20)]
        public string JZXZZ { get; set; }

        public decimal ID { get; set; }

        [StringLength(20)]
        public string YSGJ { get; set; }

        [StringLength(20)]
        public string ELOCKBH { get; set; }
    }
}
