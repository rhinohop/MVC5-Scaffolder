namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSEVENTLOG")]
    public partial class SYSEVENTLOG
    {
        [Required]
        [StringLength(36)]
        public string EVENTID { get; set; }

        [StringLength(20)]
        public string LOGINNAME { get; set; }

        [StringLength(36)]
        public string USERID { get; set; }

        [StringLength(36)]
        public string APPLICATIONID { get; set; }

        [StringLength(50)]
        public string APPLICATIONNAME { get; set; }

        [StringLength(50)]
        public string APPLICATIONCODE { get; set; }

        [StringLength(36)]
        public string MODULEID { get; set; }

        [StringLength(50)]
        public string MODULENAME { get; set; }

        [StringLength(36)]
        public string AUTHID { get; set; }

        [StringLength(50)]
        public string AUTHNAME { get; set; }

        [StringLength(50)]
        public string TYPE { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        public string RECORD { get; set; }

        public DateTime? DATETIME { get; set; }

        [StringLength(36)]
        public string ID { get; set; }

        public DateTime? SYNCTIME { get; set; }
    }
}
