namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.PDFSHRINKLOG")]
    public partial class PDFSHRINKLOG
    {
        public decimal ID { get; set; }

        public decimal? ATTACHMENTID { get; set; }

        public decimal? ISCOMPRESS { get; set; }

        public DateTime? SHRINKTIME { get; set; }

        public DateTime? CONFIRMTIME { get; set; }
    }
}
