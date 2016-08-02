namespace WebApp.Models
{
    using Repository.Pattern.Ef6;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Spatial;


    public class AUTO_CHECKRESULTMapping : EntityTypeConfiguration<AUTO_CHECKRESULT>
    {
        public AUTO_CHECKRESULTMapping()
        {
            HasKey(x => x.ID);

            Property(x => x.ID).IsRequired();
            Property(x => x.CODE).IsRequired();
            Property(x => x.HZDH).IsRequired();
            Property(x => x.KIND).IsRequired().HasMaxLength(20);

            // TODO - Change Table Names
            //ToTable("Activity"); 
        }
    }

   // [Table("CUSDOC.AUTO_CHECKRESULT")]
    public partial class AUTO_CHECKRESULT:Entity
    {
      
        public decimal ID { get; set; }

        [StringLength(20)]
        public string CODE { get; set; }

        [StringLength(20)]
        public string HZDH { get; set; }

        [StringLength(20)]
        public string KIND { get; set; }

        [StringLength(20)]
        public string HSCODE { get; set; }

        [StringLength(20)]
        public string FIELDNAME { get; set; }

        [StringLength(20)]
        public string EXCELNAME { get; set; }

        [StringLength(20)]
        public string BASENAME { get; set; }

        [StringLength(10)]
        public string ISEQUAL { get; set; }
    }
}
