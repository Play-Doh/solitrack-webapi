namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AttributeCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttributeCategory()
        {
            AttributeInfoes = new HashSet<AttributeInfo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttributeCategoryID { get; set; }

        [Required]
        public string AttributeCategoryString { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttributeInfo> AttributeInfoes { get; set; }
    }
}
