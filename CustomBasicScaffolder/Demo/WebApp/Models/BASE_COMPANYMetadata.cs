using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebApp.Models
{
    [MetadataType(typeof(BASE_COMPANYMetadata))]
    public partial class BASE_COMPANY
    {
    }

    public partial class BASE_COMPANYMetadata
    {
        [Required(ErrorMessage = "Please enter : ID")]
        [Display(Name = "ID")]
        public decimal ID { get; set; }

        [Display(Name = "代码")]
        public string CODE { get; set; }

        [Display(Name = "名称")]
        public string NAME { get; set; }

        [Display(Name = "备注")]
        public string REMARK { get; set; }

        [Display(Name = "启动")]
        public decimal ENABLED { get; set; }

        [Display(Name = "CREATEMAN")]
        public decimal CREATEMAN { get; set; }

        [Display(Name = "STOPMAN")]
        public decimal STOPMAN { get; set; }

        [Display(Name = "STARTDATE")]
        public DateTime STARTDATE { get; set; }

        [Display(Name = "ENDDATE")]
        public DateTime ENDDATE { get; set; }

        [Display(Name = "CREATEDATE")]
        public DateTime CREATEDATE { get; set; }

        [Display(Name = "ENGLISHNAME")]
        public string ENGLISHNAME { get; set; }

        [Display(Name = "DECLNATURE")]
        public string DECLNATURE { get; set; }

        [Display(Name = "INSPCODE")]
        public string INSPCODE { get; set; }

        [Display(Name = "INCODE")]
        public string INCODE { get; set; }

        [Display(Name = "INSPNATURE")]
        public string INSPNATURE { get; set; }

        [Display(Name = "GOODSLOCAL")]
        public string GOODSLOCAL { get; set; }

        [Display(Name = "RECEIVERTYPE")]
        public string RECEIVERTYPE { get; set; }

        [Display(Name = "SOCIALCREDITNO")]
        public string SOCIALCREDITNO { get; set; }

    }




	public class BASE_COMPANYChangeViewModel
    {
        public IEnumerable<BASE_COMPANY> inserted { get; set; }
        public IEnumerable<BASE_COMPANY> deleted { get; set; }
        public IEnumerable<BASE_COMPANY> updated { get; set; }
    }

}
