namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PRETCCONTAINER")]
    public partial class LIST_PRETCCONTAINER
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PRETRANCUSTOMSCODE { get; set; }

        public decimal? CONTAINERORDER { get; set; }

        [StringLength(50)]
        public string CONTAINERNO { get; set; }

        [StringLength(50)]
        public string CONTAINERTYPE { get; set; }

        [StringLength(50)]
        public string ELESHUT { get; set; }

        [StringLength(50)]
        public string TOOLNO { get; set; }

        [StringLength(50)]
        public string TOOLNAME { get; set; }

        [StringLength(50)]
        public string TOOLWEIGHT { get; set; }

        [StringLength(50)]
        public string UNITNO { get; set; }

        public decimal? CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? UPDATEBY { get; set; }

        public DateTime? UPDATEDATE { get; set; }

        public decimal? ISINVALID { get; set; }
    }
}
