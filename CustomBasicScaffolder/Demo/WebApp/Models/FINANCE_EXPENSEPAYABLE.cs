namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FINANCE_EXPENSEPAYABLE")]
    public partial class FINANCE_EXPENSEPAYABLE
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(50)]
        public string COMMISSIONNUMBER { get; set; }

        [StringLength(50)]
        public string DELEGATEMETHODID { get; set; }

        [StringLength(200)]
        public string DELEGATEMETHOD { get; set; }

        [StringLength(50)]
        public string DELEGATETYPEID { get; set; }

        [StringLength(200)]
        public string DELEGATETYPE { get; set; }

        public decimal? COSTNUMBER { get; set; }

        public decimal? WEIGHT { get; set; }

        [StringLength(50)]
        public string INVOICENUMBER { get; set; }

        [StringLength(50)]
        public string BILLLADING { get; set; }

        public DateTime? DELEGATETIME { get; set; }

        [StringLength(50)]
        public string DECLARATIONNUMBER { get; set; }

        [StringLength(50)]
        public string INSPECTIONNUMBER { get; set; }

        public decimal? CREATEMAN { get; set; }

        [StringLength(100)]
        public string CREATEMANNAME { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? COSTSTATUS { get; set; }

        [StringLength(100)]
        public string COPINGUNIT { get; set; }

        [StringLength(50)]
        public string COPINGUNITID { get; set; }

        public decimal? FJBZ { get; set; }

        public decimal? ML { get; set; }
    }
}
