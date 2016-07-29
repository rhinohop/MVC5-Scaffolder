namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.LIST_PREINSPECTION")]
    public partial class LIST_PREINSPECTION
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string PREINSPCODE { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string PREENTRYNO { get; set; }

        [StringLength(50)]
        public string DECLTYPE { get; set; }

        [StringLength(50)]
        public string INSPTYPE { get; set; }

        [StringLength(50)]
        public string INSPAGENCY { get; set; }

        [StringLength(50)]
        public string AIMORGANIZATION { get; set; }

        [StringLength(50)]
        public string DECLUNIT { get; set; }

        [StringLength(10)]
        public string INSPUNITCONTACT { get; set; }

        [StringLength(50)]
        public string INSPUNITPHONE { get; set; }

        public decimal? INSPNODE { get; set; }

        [StringLength(50)]
        public string OPERATORS { get; set; }

        [StringLength(50)]
        public string CUSTOMSOFFICERID { get; set; }

        [StringLength(50)]
        public string CLEARANCENO { get; set; }

        [StringLength(50)]
        public string CUSTOMSRECORDNO { get; set; }

        public DateTime? RECEIVEDATE { get; set; }

        public DateTime? UNLOADDATE { get; set; }

        public DateTime? DECLDATE { get; set; }

        [StringLength(50)]
        public string GROUPBATCH { get; set; }

        [StringLength(50)]
        public string EXPORTBATCH { get; set; }

        [StringLength(50)]
        public string ENTRYPORT { get; set; }

        [StringLength(50)]
        public string CONTRACTNO { get; set; }

        [StringLength(50)]
        public string UPCN { get; set; }

        [StringLength(50)]
        public string UPEN { get; set; }

        [StringLength(50)]
        public string DOWNCN { get; set; }

        [StringLength(50)]
        public string DOWNEN { get; set; }

        [StringLength(50)]
        public string BUSINATURE { get; set; }

        [StringLength(50)]
        public string TRANSTOOL { get; set; }

        [StringLength(50)]
        public string TOTALNO { get; set; }

        [StringLength(50)]
        public string DIVIDENO { get; set; }

        public decimal? FOREIGNPROPERTY { get; set; }

        [StringLength(50)]
        public string SHIPNAME { get; set; }

        [StringLength(50)]
        public string FILGHTNO { get; set; }

        [StringLength(50)]
        public string LADINGNO { get; set; }

        public decimal? ISRETURN { get; set; }

        [StringLength(50)]
        public string TRADE { get; set; }

        [StringLength(50)]
        public string FOBPORT { get; set; }

        [StringLength(50)]
        public string MIDPORT { get; set; }

        [StringLength(50)]
        public string DESTINATION { get; set; }

        [StringLength(50)]
        public string TRADECOUNTRY { get; set; }

        [StringLength(50)]
        public string FOBCOUNTRY { get; set; }

        [StringLength(50)]
        public string GOODSSTORE { get; set; }

        [StringLength(50)]
        public string CREDITNO { get; set; }

        public decimal? GOODSNUM { get; set; }

        [StringLength(50)]
        public string PACKAGETYPE { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSGW { get; set; }

        [Column(TypeName = "float")]
        public decimal? GOODSNW { get; set; }

        [StringLength(50)]
        public string ISWOODPACK { get; set; }

        public decimal? ASSISTPACKNUM { get; set; }

        [StringLength(10)]
        public string ISIPPC { get; set; }

        [StringLength(50)]
        public string OFFIXEDOFFERCODE { get; set; }

        [StringLength(50)]
        public string OFFIXEDOFFEREN { get; set; }

        [StringLength(50)]
        public string OFFIXEDOFFERCN { get; set; }

        [StringLength(50)]
        public string REGUAREATYPE { get; set; }

        public DateTime? CLAIMANTDATE { get; set; }

        public decimal? FOREIGNCOMPANY { get; set; }

        public decimal? ISDECLPLACE { get; set; }

        [StringLength(500)]
        public string MARKSNOSREMARKS { get; set; }

        [StringLength(500)]
        public string SPECIALREQUEST { get; set; }

        [StringLength(50)]
        public string ACCDOCUMENTS { get; set; }

        [StringLength(50)]
        public string NEEDDOC { get; set; }

        [StringLength(500)]
        public string CSREMARK { get; set; }

        [StringLength(50)]
        public string BUSINO { get; set; }

        [StringLength(50)]
        public string CUSOPERATNO { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        public decimal? CSID { get; set; }

        public decimal? MOID { get; set; }

        public decimal? COID { get; set; }

        public DateTime? DISTRIBUTETIME { get; set; }

        public DateTime? MOACCEPTTIME { get; set; }

        public decimal? ISINVALID { get; set; }

        [StringLength(50)]
        public string PREDECLCODE { get; set; }

        [StringLength(50)]
        public string ASSISTPACKTYPE { get; set; }

        public DateTime? MOSTARTTIME { get; set; }

        public decimal? MOTIME { get; set; }

        public DateTime? CSSTARTTIME { get; set; }

        public decimal? CSTIME { get; set; }

        public decimal? ISPAUSE { get; set; }

        [StringLength(50)]
        public string DECLUNITNATURE { get; set; }

        public decimal? PAGENO { get; set; }

        [StringLength(50)]
        public string CUSTOMERTRADWAY { get; set; }

        [StringLength(500)]
        public string FACTORYINSPECTIONINFO { get; set; }

        public DateTime? MOENDTIME { get; set; }

        [StringLength(100)]
        public string INSPAGENCYNAME { get; set; }

        [StringLength(100)]
        public string AIMORGANIZATIONNAME { get; set; }

        [StringLength(100)]
        public string DECLUNITNAME { get; set; }

        [StringLength(100)]
        public string OPERATORSNAME { get; set; }

        [StringLength(100)]
        public string ENTRYPORTNAME { get; set; }

        [StringLength(100)]
        public string UPCNNAME { get; set; }

        [StringLength(100)]
        public string DOWNCNNAME { get; set; }

        [StringLength(100)]
        public string FOBPORTNAME { get; set; }

        [StringLength(100)]
        public string MIDPORTNAME { get; set; }

        [StringLength(100)]
        public string GOODSSTORENAME { get; set; }

        [StringLength(20)]
        public string UNITYCODE { get; set; }

        public decimal? PAUSENUM { get; set; }

        [StringLength(20)]
        public string REPORTREGION { get; set; }

        [StringLength(100)]
        public string REPORTREGIONNAME { get; set; }

        public DateTime? CSSUBMITTIME { get; set; }

        [StringLength(20)]
        public string MONAME { get; set; }

        public decimal? MOSUBMITUSERID { get; set; }

        [StringLength(50)]
        public string MOSUBMITUSERNAME { get; set; }

        public DateTime? MOSUBMITTIME { get; set; }
    }
}
