namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CHATTOPIC")]
    public partial class CHATTOPIC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHATTOPIC()
        {
            CHATMESSAGEs = new HashSet<CHATMESSAGE>();
            CHATTOPICRECEIVERs = new HashSet<CHATTOPICRECEIVER>();
        }

        [StringLength(32)]
        public string ID { get; set; }

        public decimal? ORDERID { get; set; }

        [StringLength(1)]
        public string ISCLOSE { get; set; }

        public DateTime? CREATEDATE { get; set; }

        public decimal? CREATEUSER { get; set; }

        public DateTime? EDITDATE { get; set; }

        public decimal? EDITUSER { get; set; }

        [StringLength(10)]
        public string INOUTTYPE { get; set; }

        [StringLength(10)]
        public string CHATTYPE { get; set; }

        [StringLength(10)]
        public string UNUSUALCLASS { get; set; }

        public string CHATTOPICMSG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATMESSAGE> CHATMESSAGEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATTOPICRECEIVER> CHATTOPICRECEIVERs { get; set; }

        public virtual SYS_USER SYS_USER { get; set; }

        public virtual SYS_USER SYS_USER1 { get; set; }

        public virtual LIST_ORDER LIST_ORDER { get; set; }
    }
}
