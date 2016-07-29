namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSMSGSENDED")]
    public partial class SYSMSGSENDED
    {
        [StringLength(36)]
        public string ID { get; set; }

        [StringLength(11)]
        public string SENDTOPHONE { get; set; }

        [StringLength(1000)]
        public string CONTENT { get; set; }

        [StringLength(10)]
        public string STATE { get; set; }

        public DateTime? CREATETIME { get; set; }

        public DateTime? SENDEDTIME { get; set; }

        [StringLength(100)]
        public string EXT1 { get; set; }

        [StringLength(100)]
        public string EXT2 { get; set; }

        [StringLength(100)]
        public string EXT3 { get; set; }

        [StringLength(100)]
        public string EXT4 { get; set; }

        [StringLength(100)]
        public string EXT5 { get; set; }
    }
}
