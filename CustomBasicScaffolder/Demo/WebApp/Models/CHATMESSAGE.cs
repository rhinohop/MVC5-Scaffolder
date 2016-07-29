namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CHATMESSAGE")]
    public partial class CHATMESSAGE
    {
        [StringLength(32)]
        public string ID { get; set; }

        [StringLength(32)]
        public string CHATTOPICID { get; set; }

        public decimal? SENDUSER { get; set; }

        [StringLength(50)]
        public string SENDUSERNAME { get; set; }

        public DateTime? SENDDATE { get; set; }

        public decimal? RECEVERUSER { get; set; }

        [StringLength(50)]
        public string RECEVERUSERNAME { get; set; }

        public DateTime? READDATE { get; set; }

        [StringLength(1)]
        public string ISREAD { get; set; }

        [StringLength(1)]
        public string OffLine { get; set; }

        [StringLength(1)]
        public string ISFILE { get; set; }

        [StringLength(100)]
        public string FILENAME { get; set; }

        [StringLength(1000)]
        public string FILEPATH { get; set; }

        [StringLength(1000)]
        public string RECFILEPATH { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? CREATEUSER { get; set; }

        public DateTime? EDITDATE { get; set; }

        public decimal? EDITUSER { get; set; }

        public string MESSAGE { get; set; }

        [StringLength(32)]
        public string SAMEGUID { get; set; }

        public string GIFSMSG { get; set; }

        [StringLength(1000)]
        public string SERVERFILEPATH { get; set; }

        public virtual CHATTOPIC CHATTOPIC { get; set; }

        public virtual SYS_USER SYS_USER { get; set; }

        public virtual SYS_USER SYS_USER1 { get; set; }

        public virtual SYS_USER SYS_USER2 { get; set; }

        public virtual SYS_USER SYS_USER3 { get; set; }
    }
}
