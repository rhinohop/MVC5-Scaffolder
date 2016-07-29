namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.TASK_ZGD")]
    public partial class TASK_ZGD
    {
        public decimal ID { get; set; }

        [StringLength(50)]
        public string MASTERNO { get; set; }

        [StringLength(50)]
        public string HOSTNO { get; set; }

        [StringLength(50)]
        public string ORDERCODE { get; set; }

        [StringLength(50)]
        public string CUSTOM28JOBNO { get; set; }

        [StringLength(1)]
        public string ISENABLED { get; set; }
    }
}
