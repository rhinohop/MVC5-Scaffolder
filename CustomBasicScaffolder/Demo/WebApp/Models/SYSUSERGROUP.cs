namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSUSERGROUP")]
    public partial class SYSUSERGROUP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string GROUPID { get; set; }

        [StringLength(200)]
        public string PK_USERID { get; set; }

        [StringLength(36)]
        public string PK_GW { get; set; }

        [StringLength(36)]
        public string PK_DEPTDOC { get; set; }

        [StringLength(36)]
        public string PK_CORP { get; set; }

        [StringLength(36)]
        public string PK_ZW { get; set; }

        [StringLength(36)]
        public string PK_XL { get; set; }

        [StringLength(36)]
        public string PK_RYLB { get; set; }

        [StringLength(50)]
        public string INDUTYDATE { get; set; }

        [StringLength(50)]
        public string HTBEGINDATE { get; set; }

        [StringLength(50)]
        public string HTENDDATE { get; set; }

        [StringLength(36)]
        public string PK_JNDJ { get; set; }

        [StringLength(20)]
        public string OUTDUTYDATE { get; set; }

        [StringLength(50)]
        public string POSTLAVEL { get; set; }

        [StringLength(20)]
        public string DATATYPE { get; set; }
    }
}
