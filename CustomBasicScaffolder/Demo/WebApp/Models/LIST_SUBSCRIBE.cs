namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_SUBSCRIBE")]
    public partial class LIST_SUBSCRIBE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string FIELD { get; set; }

        [StringLength(50)]
        public string FIELDNAME { get; set; }

        public decimal? SUBSCRIBEBYID { get; set; }

        [StringLength(50)]
        public string SUBSCRIBEBYNAME { get; set; }

        public DateTime? SUBSCRIBEDATE { get; set; }

        public decimal? ISSUBSCRIBE { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? DONEBYID { get; set; }

        public DateTime? DONEDATE { get; set; }

        [StringLength(50)]
        public string DONEBYNAME { get; set; }
    }
}
