namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BGJ_SUBDATA")]
    public partial class BGJ_SUBDATA
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PID { get; set; }

        [StringLength(50)]
        public string SP_NO { get; set; }

        [StringLength(50)]
        public string BA_NO { get; set; }

        [StringLength(50)]
        public string SPBH_NO { get; set; }

        [StringLength(50)]
        public string FJBH_NO { get; set; }

        [StringLength(200)]
        public string SPMC_NAME { get; set; }

        [StringLength(250)]
        public string GGXH { get; set; }

        [StringLength(50)]
        public string CJ_NO { get; set; }

        [StringLength(20)]
        public string CJDW { get; set; }

        [StringLength(20)]
        public string CJDJ { get; set; }

        public decimal? CJZJ { get; set; }

        [StringLength(50)]
        public string BIZHONG { get; set; }

        [StringLength(50)]
        public string FD_NO { get; set; }

        [StringLength(50)]
        public string FDDW { get; set; }

        [StringLength(50)]
        public string BBH_NO { get; set; }

        [StringLength(50)]
        public string HH_NO { get; set; }

        [StringLength(50)]
        public string YT { get; set; }

        [StringLength(50)]
        public string DESL { get; set; }

        [StringLength(50)]
        public string DEDW { get; set; }

        [StringLength(50)]
        public string YCD { get; set; }

        [StringLength(50)]
        public string ZM { get; set; }

        [StringLength(50)]
        public string GJF { get; set; }

        [StringLength(50)]
        public string SCCJ { get; set; }

        public DateTime? GJSJ { get; set; }

        [StringLength(20)]
        public string GJRY { get; set; }

        [StringLength(1)]
        public string GJFLAG { get; set; }

        [StringLength(1)]
        public string BGDFLAG { get; set; }
    }
}
