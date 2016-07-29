namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSEVENTCONFIG")]
    public partial class SYSEVENTCONFIG
    {
        [StringLength(36)]
        public string ID { get; set; }

        [StringLength(50)]
        public string APPCODE { get; set; }

        [StringLength(200)]
        public string APPNAME { get; set; }

        [StringLength(500)]
        public string DBCONSTR { get; set; }

        [StringLength(100)]
        public string DBTYPE { get; set; }

        [StringLength(100)]
        public string GRABINTERVAL { get; set; }

        [StringLength(500)]
        public string EXT1 { get; set; }

        [StringLength(500)]
        public string EXT2 { get; set; }

        [StringLength(50)]
        public string DBTABLENAME { get; set; }

        public DateTime? CREATETIME { get; set; }

        [StringLength(50)]
        public string CREATENAME { get; set; }

        [StringLength(36)]
        public string CREATEID { get; set; }

        [StringLength(500)]
        public string SELECTSQL { get; set; }

        [StringLength(50)]
        public string SIGNFIELD { get; set; }
    }
}
