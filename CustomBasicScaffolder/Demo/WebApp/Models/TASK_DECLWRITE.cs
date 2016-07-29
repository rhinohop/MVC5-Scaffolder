namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_DECLWRITE")]
    public partial class TASK_DECLWRITE
    {
        public decimal ID { get; set; }

        [StringLength(25)]
        public string CODE { get; set; }

        [StringLength(25)]
        public string CUSTOMER { get; set; }

        [StringLength(50)]
        public string CUSTOMERNAME { get; set; }

        [StringLength(25)]
        public string DECLTYPE { get; set; }

        [StringLength(50)]
        public string DECLTYPENAME { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? USERID { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        public DateTime? SENDTIME { get; set; }

        public DateTime? FINISHTIME { get; set; }

        [StringLength(50)]
        public string BUSIUNIT { get; set; }

        [StringLength(50)]
        public string BUSIUNITNAME { get; set; }

        [StringLength(50)]
        public string BUSITYPE { get; set; }

        [StringLength(50)]
        public string BUSITYPENAME { get; set; }

        [StringLength(50)]
        public string CURRENTCODE { get; set; }
    }
}
