namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYSTASK")]
    public partial class SYSTASK
    {
        [StringLength(36)]
        public string ID { get; set; }

        [StringLength(36)]
        public string PID { get; set; }

        [Required]
        [StringLength(50)]
        public string TITLE { get; set; }

        [Required]
        [StringLength(36)]
        public string WORKNO { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string WORKFLOWNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string CURRENTNODENAME { get; set; }

        public DateTime? CREATEDTIME { get; set; }

        public DateTime? UPDATEDTIME { get; set; }

        public DateTime? FINISHTIME { get; set; }

        [StringLength(100)]
        public string STATUS { get; set; }

        [StringLength(100)]
        public string TYPE { get; set; }

        [StringLength(200)]
        public string URL { get; set; }

        [StringLength(100)]
        public string RESULT { get; set; }

        [StringLength(100)]
        public string EXT1 { get; set; }

        [StringLength(100)]
        public string EXT2 { get; set; }

        [StringLength(100)]
        public string EXT3 { get; set; }

        [StringLength(100)]
        public string EXT4 { get; set; }

        [StringLength(100)]
        public string EXT5 { get; set; }
    }
}
