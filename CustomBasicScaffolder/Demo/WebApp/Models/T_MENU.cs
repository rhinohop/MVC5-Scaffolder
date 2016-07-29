namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.T_MENU")]
    public partial class T_MENU
    {
        [Key]
        public decimal MENUID { get; set; }

        [StringLength(50)]
        public string MENUNAME { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        [StringLength(255)]
        public string FRMNAME { get; set; }

        public decimal? PARENTMENUID { get; set; }

        [StringLength(255)]
        public string ASSEMBLYNAME { get; set; }

        [StringLength(255)]
        public string ARGS { get; set; }
    }
}
