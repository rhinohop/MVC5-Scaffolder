namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.SYS_USER")]
    public partial class SYS_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_USER()
        {
            CHATMESSAGEs = new HashSet<CHATMESSAGE>();
            CHATMESSAGEs1 = new HashSet<CHATMESSAGE>();
            CHATMESSAGEs2 = new HashSet<CHATMESSAGE>();
            CHATMESSAGEs3 = new HashSet<CHATMESSAGE>();
            CHATTOPICs = new HashSet<CHATTOPIC>();
            CHATTOPICs1 = new HashSet<CHATTOPIC>();
        }

        public decimal ID { get; set; }

        public decimal? CUSTOMERID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string REALNAME { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public decimal? SEX { get; set; }

        [StringLength(50)]
        public string TELEPHONE { get; set; }

        [StringLength(50)]
        public string MOBILEPHONE { get; set; }

        public decimal? TYPE { get; set; }

        public decimal? ENABLED { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        public decimal? POINTS { get; set; }

        public decimal? AREAID { get; set; }

        public decimal? POSITIONID { get; set; }

        public decimal? PRETYPE { get; set; }

        [StringLength(50)]
        public string BUSITYPES { get; set; }

        [StringLength(50)]
        public string DEFAULTORDERSEARCH { get; set; }

        [StringLength(50)]
        public string CODE { get; set; }

        public decimal? PARENTID { get; set; }

        public DateTime? CREATETIME { get; set; }

        [StringLength(30)]
        public string CURRENTIP { get; set; }

        [StringLength(30)]
        public string CURRENTPORT { get; set; }

        [StringLength(1)]
        public string CONNECTED { get; set; }

        [StringLength(255)]
        public string FTPSERVERURL { get; set; }

        [StringLength(50)]
        public string FTPACCOUNT { get; set; }

        [StringLength(50)]
        public string FTPPASSWORD { get; set; }

        [StringLength(255)]
        public string IMGPATH { get; set; }

        [StringLength(255)]
        public string SIMROLE { get; set; }

        [StringLength(255)]
        public string COMPANYIDS { get; set; }

        [StringLength(255)]
        public string COMPANYNAMES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATMESSAGE> CHATMESSAGEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATMESSAGE> CHATMESSAGEs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATMESSAGE> CHATMESSAGEs2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATMESSAGE> CHATMESSAGEs3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATTOPIC> CHATTOPICs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHATTOPIC> CHATTOPICs1 { get; set; }
    }
}
