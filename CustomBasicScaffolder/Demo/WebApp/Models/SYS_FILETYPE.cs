namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_FILETYPE")]
    public partial class SYS_FILETYPE
    {
        [Key]
        [Column(Order = 0)]
        public decimal FILETYPEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FILETYPENAME { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        public decimal? PARENTFILETYPEID { get; set; }

        public decimal? FILEUSE { get; set; }

        public decimal? SORTINDEX { get; set; }

        public decimal? ENABLED { get; set; }

        public decimal? FILEKIND { get; set; }

        [StringLength(50)]
        public string EDOCFILETYPE { get; set; }
    }
}
