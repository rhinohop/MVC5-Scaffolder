namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FIN_RECEIVABLERULESCUS_H")]
    public partial class FIN_RECEIVABLERULESCUS_H
    {
        [Key]
        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string PCODE { get; set; }

        [StringLength(50)]
        public string CLEARUNIT { get; set; }

        [StringLength(50)]
        public string CLEARUNITNAME { get; set; }

        [StringLength(50)]
        public string CUSTOMES { get; set; }

        [StringLength(50)]
        public string CUSTOMNAMES { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? CREATEUSERID { get; set; }

        [StringLength(50)]
        public string CREATEUSERNAME { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? CHECKTIME { get; set; }

        public decimal? CHECKUSERID { get; set; }

        [StringLength(50)]
        public string CHECKUSERNAME { get; set; }

        public decimal? ENABLED { get; set; }

        public DateTime? STOPTIME { get; set; }

        public decimal? STOPUSERID { get; set; }

        [StringLength(50)]
        public string STOPUSERNAME { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }
    }
}
