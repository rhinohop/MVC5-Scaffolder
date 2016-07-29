namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSDOC.CODESMITH_EXTENDED_PROPERTIES")]
    public partial class CODESMITH_EXTENDED_PROPERTIES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CONTAINER_OBJECT_OWNER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(61)]
        public string OBJECT_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string CODESMITH_SCHEMA_TYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(75)]
        public string PROPERTY_NAME { get; set; }

        [StringLength(4000)]
        public string PROPERTY_VALUE { get; set; }

        [Required]
        [StringLength(50)]
        public string CLR_TYPE { get; set; }
    }
}
