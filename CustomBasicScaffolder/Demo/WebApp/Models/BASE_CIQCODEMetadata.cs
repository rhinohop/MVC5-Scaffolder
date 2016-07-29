using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebApp.Models
{
    [MetadataType(typeof(BASE_CIQCODEMetadata))]
    public partial class BASE_CIQCODE
    {
    }

    public partial class BASE_CIQCODEMetadata
    {
        [Required(ErrorMessage = "Please enter : ID")]
        [Display(Name = "ID")]
        public decimal ID { get; set; }

        [Display(Name = "CIQ")]
        public string CIQ { get; set; }

        [Display(Name = "CIQNAME")]
        public string CIQNAME { get; set; }

        [Display(Name = "ENABLED")]
        public decimal ENABLED { get; set; }

        [Display(Name = "CREATEMAN")]
        public decimal CREATEMAN { get; set; }

        [Display(Name = "STOPMAN")]
        public decimal STOPMAN { get; set; }

        [Display(Name = "CREATEDATE")]
        public DateTime CREATEDATE { get; set; }

        [Display(Name = "STARTDATE")]
        public DateTime STARTDATE { get; set; }

        [Display(Name = "ENDDATE")]
        public DateTime ENDDATE { get; set; }

        [Display(Name = "YEARID")]
        public decimal YEARID { get; set; }

        [Display(Name = "REMARK")]
        public string REMARK { get; set; }

    }




	public class BASE_CIQCODEChangeViewModel
    {
        public IEnumerable<BASE_CIQCODE> inserted { get; set; }
        public IEnumerable<BASE_CIQCODE> deleted { get; set; }
        public IEnumerable<BASE_CIQCODE> updated { get; set; }
    }

}
