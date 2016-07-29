namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_CUSTOMER")]
    public partial class SYS_CUSTOMER
    {
        public decimal ID { get; set; }

        [StringLength(255)]
        public string CODE { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string CHINESEABBREVIATION { get; set; }

        [StringLength(255)]
        public string CHINESEADDRESS { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string HSCODE { get; set; }

        [StringLength(50)]
        public string CIQCODE { get; set; }

        [StringLength(255)]
        public string ENGLISHNAME { get; set; }

        [StringLength(255)]
        public string ENGLISHADDRESS { get; set; }

        [StringLength(50)]
        public string SOCIALCREDITNO { get; set; }

        [StringLength(50)]
        public string INTERFACECODE { get; set; }

        public decimal? ISCUSTOMER { get; set; }

        public decimal? ISSHIPPER { get; set; }

        public decimal? ISCOMPANY { get; set; }

        public decimal? SCENEDECLAREID { get; set; }

        public decimal? SCENEINSPECTID { get; set; }

        public decimal? SELFCHECK { get; set; }

        public decimal? WEIGHTCHECK { get; set; }

        [StringLength(255)]
        public string BUSITYPES { get; set; }
    }
}
