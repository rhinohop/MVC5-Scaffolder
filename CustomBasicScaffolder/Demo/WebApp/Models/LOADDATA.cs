namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LOADDATA")]
    public partial class LOADDATA
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string TY_NO { get; set; }

        [StringLength(50)]
        public string YLR_NO { get; set; }

        [StringLength(50)]
        public string JKKA { get; set; }

        [StringLength(50)]
        public string BA_NO { get; set; }

        [StringLength(50)]
        public string HG_NO { get; set; }

        [StringLength(50)]
        public string HT_NO { get; set; }

        public DateTime? JK_DATE { get; set; }

        public DateTime? SB_DATE { get; set; }

        [StringLength(100)]
        public string JYDW_NO { get; set; }

        [StringLength(50)]
        public string JYDW_NAME { get; set; }

        [StringLength(50)]
        public string JYDW_XZ { get; set; }

        [StringLength(50)]
        public string SHDW_NO { get; set; }

        [StringLength(50)]
        public string SHDW_NAME { get; set; }

        [StringLength(50)]
        public string SHDW_XZ { get; set; }

        [StringLength(50)]
        public string SBDW_NO { get; set; }

        [StringLength(50)]
        public string SBDW_NAME { get; set; }

        [StringLength(50)]
        public string SBDW_XZ { get; set; }

        [StringLength(50)]
        public string YSFS { get; set; }

        [StringLength(50)]
        public string YSGJ { get; set; }

        [StringLength(50)]
        public string HC_NO { get; set; }

        [StringLength(50)]
        public string TIYUN_NO { get; set; }

        [StringLength(50)]
        public string JGFS { get; set; }

        [StringLength(50)]
        public string ZMXZ { get; set; }

        [StringLength(50)]
        public string ZSBL { get; set; }

        [StringLength(50)]
        public string NSDW { get; set; }

        [StringLength(50)]
        public string XK_NO { get; set; }

        [StringLength(50)]
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

        [StringLength(50)]
        public string OPERTOR { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        public decimal? SPXS { get; set; }

        [StringLength(50)]
        public string DJZT { get; set; }

        [StringLength(50)]
        public string YWBH { get; set; }

        public DateTime? SJSJ { get; set; }

        public DateTime? FSSJ { get; set; }

        public DateTime? GJSJ { get; set; }

        [StringLength(50)]
        public string ZCTY_NO { get; set; }

        [StringLength(50)]
        public string XZLB { get; set; }

        [Required]
        [StringLength(5)]
        public string SJBZ { get; set; }

        [StringLength(50)]
        public string DJBM { get; set; }

        [StringLength(100)]
        public string XZKB { get; set; }

        [StringLength(50)]
        public string YFDM { get; set; }

        [StringLength(50)]
        public string BFDM { get; set; }

        [StringLength(50)]
        public string ZFDM { get; set; }

        [StringLength(50)]
        public string SBXC { get; set; }

        [StringLength(50)]
        public string GLBGD { get; set; }

        [StringLength(50)]
        public string GLBA { get; set; }

        [StringLength(100)]
        public string QDLX { get; set; }

        [StringLength(50)]
        public string SFHXYDM { get; set; }

        [StringLength(50)]
        public string XFDWXYDM { get; set; }

        [StringLength(50)]
        public string SBDWXYDM { get; set; }

        [StringLength(50)]
        public string MYG { get; set; }

        [StringLength(10)]
        public string TSGXQR { get; set; }

        [StringLength(10)]
        public string JGYXQR { get; set; }

        [StringLength(10)]
        public string ZFTSQ { get; set; }

        public decimal? ERROR { get; set; }
    }
}
