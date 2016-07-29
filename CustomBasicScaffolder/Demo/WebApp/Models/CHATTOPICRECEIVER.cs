namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CHATTOPICRECEIVER")]
    public partial class CHATTOPICRECEIVER
    {
        [StringLength(32)]
        public string ID { get; set; }

        public decimal? RECEIVERID { get; set; }

        [StringLength(10)]
        public string RECEIVERNAME { get; set; }

        [StringLength(32)]
        public string CHATTOPICID { get; set; }

        public virtual CHATTOPIC CHATTOPIC { get; set; }
    }
}
