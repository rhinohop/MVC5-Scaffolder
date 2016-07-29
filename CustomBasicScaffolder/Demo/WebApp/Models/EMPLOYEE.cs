namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.EMPLOYEE")]
    public partial class EMPLOYEE
    {
        [Key]
        public decimal E_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string E_NAME { get; set; }

        public decimal? E_DEP { get; set; }

        [StringLength(2)]
        public string E_SEX { get; set; }

        [StringLength(20)]
        public string E_POS { get; set; }

        [StringLength(50)]
        public string E_PWD { get; set; }

        public decimal? E_ISSUP { get; set; }

        [StringLength(50)]
        public string E_ADD1 { get; set; }

        [StringLength(50)]
        public string E_ADD2 { get; set; }

        [StringLength(11)]
        public string E_MOBILE { get; set; }

        [StringLength(20)]
        public string C_NAME { get; set; }
    }
}
