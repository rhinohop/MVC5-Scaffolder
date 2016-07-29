namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.BGJ_LOADDATA")]
    public partial class BGJ_LOADDATA
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        [StringLength(30)]
        public string TY_NO { get; set; }

        [StringLength(50)]
        public string YLR_NO { get; set; }

        [StringLength(30)]
        public string JKKA { get; set; }

        [StringLength(50)]
        public string BA_NO { get; set; }

        [StringLength(50)]
        public string HG_NO { get; set; }

        [StringLength(50)]
        public string HT_NO { get; set; }

        public DateTime? JK_DATE { get; set; }

        public DateTime? SB_DATE { get; set; }

        [StringLength(20)]
        public string JYDW_NO { get; set; }

        [StringLength(200)]
        public string JYDW_NAME { get; set; }

        [StringLength(20)]
        public string JYDW_XZ { get; set; }

        [StringLength(20)]
        public string SHDW_NO { get; set; }

        [StringLength(60)]
        public string SHDW_NAME { get; set; }

        [StringLength(20)]
        public string SHDW_XZ { get; set; }

        [StringLength(20)]
        public string SBDW_NO { get; set; }

        [StringLength(60)]
        public string SBDW_NAME { get; set; }

        [StringLength(20)]
        public string SBDW_XZ { get; set; }

        [StringLength(50)]
        public string YSFS { get; set; }

        [StringLength(50)]
        public string YSGJ { get; set; }

        [StringLength(20)]
        public string HC_NO { get; set; }

        [StringLength(50)]
        public string TIYUN_NO { get; set; }

        [StringLength(20)]
        public string JGFS { get; set; }

        [StringLength(20)]
        public string ZMXZ { get; set; }

        [StringLength(50)]
        public string ZSBL { get; set; }

        [StringLength(50)]
        public string NSDW { get; set; }

        [StringLength(50)]
        public string XK_NO { get; set; }

        [StringLength(20)]
        public string QYG { get; set; }

        [StringLength(50)]
        public string ZHG { get; set; }

        [StringLength(50)]
        public string JNMDD { get; set; }

        [StringLength(50)]
        public string PZ_NO { get; set; }

        [StringLength(50)]
        public string CJFS { get; set; }

        [StringLength(50)]
        public string YUNFEE { get; set; }

        [StringLength(50)]
        public string YBIZHONG { get; set; }

        [StringLength(50)]
        public string BAOFEE { get; set; }

        [StringLength(50)]
        public string BBIZHONG { get; set; }

        [StringLength(50)]
        public string ZAFEE { get; set; }

        [StringLength(50)]
        public string ZBIZHONG { get; set; }

        [StringLength(50)]
        public string JIANSHU { get; set; }

        [StringLength(50)]
        public string BZZL { get; set; }

        [StringLength(50)]
        public string MAOZHONG { get; set; }

        [StringLength(50)]
        public string JINGZHONG { get; set; }

        [StringLength(50)]
        public string JZX_NO { get; set; }

        [StringLength(50)]
        public string SFDZ_NO { get; set; }

        [StringLength(50)]
        public string BGDTYPE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public DateTime? INDATE { get; set; }

        [StringLength(50)]
        public string INOUTTYPE { get; set; }

        [StringLength(20)]
        public string OPERTOR { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        public decimal? SPXS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string YWBH { get; set; }

        public DateTime? SJSJ { get; set; }

        [StringLength(20)]
        public string SJRY { get; set; }

        [StringLength(1)]
        public string SJFLAG { get; set; }

        public decimal? BGDTS { get; set; }

        public DateTime? FSSJ { get; set; }

        [StringLength(20)]
        public string FSRY { get; set; }

        [StringLength(1)]
        public string FSFLAG { get; set; }

        public DateTime? GJSJ { get; set; }

        [StringLength(20)]
        public string GJRY { get; set; }

        [StringLength(1)]
        public string GJFLAG { get; set; }

        [StringLength(1)]
        public string BGDFLAG { get; set; }

        [StringLength(50)]
        public string YSBGDH { get; set; }

        public decimal? SJBGDTS { get; set; }
    }
}
