namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_CSPOND")]
    public partial class LIST_CSPOND
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string PRECS { get; set; }

        [StringLength(50)]
        public string PREMO { get; set; }

        [StringLength(50)]
        public string PRECO { get; set; }

        [StringLength(50)]
        public string PREDECL { get; set; }

        [StringLength(50)]
        public string PREINSP { get; set; }

        [StringLength(50)]
        public string PREREGU { get; set; }

        public decimal? PRIORITY { get; set; }

        public decimal? ISBACK { get; set; }

        public decimal? STATUS { get; set; }

        [StringLength(50)]
        public string CORRESPONDENCENO { get; set; }

        [StringLength(50)]
        public string ASSOCIATENO { get; set; }

        public decimal? BUSITYPE { get; set; }

        public decimal? INVALID { get; set; }

        public decimal? EXTRASTATUS { get; set; }
    }
}
