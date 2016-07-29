namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_ATTACHMENTDETAIL")]
    public partial class LIST_ATTACHMENTDETAIL
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string SOURCEFILENAME { get; set; }

        [StringLength(50)]
        public string FILENAME { get; set; }

        [StringLength(255)]
        public string FILEPATH { get; set; }

        public decimal? ATTACHMENTID { get; set; }

        public decimal? FILETYPEID { get; set; }

        public DateTime? SPLITETIME { get; set; }

        [StringLength(50)]
        public string SPLITEUSER { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(1000)]
        public string PAGES { get; set; }

        [StringLength(50)]
        public string SPLITEUSERNAME { get; set; }

        public decimal? ISREP { get; set; }
    }
}
