namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.AUTO_CHECKRESULT")]
    public partial class AUTO_CHECKRESULT
    {
        public decimal ID { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(20)]
        public string HZDH { get; set; }

        [StringLength(20)]
        public string KIND { get; set; }

        [StringLength(20)]
        public string HSCODE { get; set; }

        [StringLength(20)]
        public string FIELDNAME { get; set; }

        [StringLength(20)]
        public string EXCELNAME { get; set; }

        [StringLength(20)]
        public string BASENAME { get; set; }

        [StringLength(10)]
        public string ISEQUAL { get; set; }
    }
}
