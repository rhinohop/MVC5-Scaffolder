namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.FIN_RECEIVABLERULESCUS_D")]
    public partial class FIN_RECEIVABLERULESCUS_D
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PARENTID { get; set; }

        [StringLength(20)]
        public string CLEARCODE { get; set; }

        [StringLength(20)]
        public string COSTCODE { get; set; }

        [StringLength(10)]
        public string LOGIC { get; set; }

        [StringLength(20)]
        public string CALCONDITION { get; set; }

        [StringLength(20)]
        public string CALFORMULA { get; set; }

        [Column(TypeName = "float")]
        public decimal? PRICE { get; set; }

        [StringLength(10)]
        public string CURRENCY { get; set; }

        [Column(TypeName = "float")]
        public decimal? MAXVALUES { get; set; }

        [Column(TypeName = "float")]
        public decimal? MINVALUES { get; set; }

        [StringLength(10)]
        public string ISRATE { get; set; }

        [Column(TypeName = "float")]
        public decimal? RATE { get; set; }

        public decimal? ENABLED { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal? CREATEMAN { get; set; }

        public decimal? STOPMAN { get; set; }

        [StringLength(200)]
        public string EXEXSQL { get; set; }

        [StringLength(200)]
        public string REMARK { get; set; }

        [StringLength(200)]
        public string PRICEDES { get; set; }

        [Column(TypeName = "float")]
        public decimal? PRICEPARA { get; set; }

        [Column(TypeName = "float")]
        public decimal? PRICEVAL { get; set; }

        [StringLength(50)]
        public string RULEEXEFIELD { get; set; }

        [StringLength(50)]
        public string RULEEXEFIELDNAME { get; set; }

        [StringLength(500)]
        public string EXEXSQLNAME { get; set; }
    }
}
