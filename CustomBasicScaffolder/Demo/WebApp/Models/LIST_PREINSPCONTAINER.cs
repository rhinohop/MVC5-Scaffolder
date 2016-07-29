namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PREINSPCONTAINER")]
    public partial class LIST_PREINSPCONTAINER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CONTAINERNO { get; set; }

        [StringLength(50)]
        public string FORMATNAME { get; set; }

        [StringLength(50)]
        public string HSCODE { get; set; }

        public decimal? NUM { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }
    }
}
