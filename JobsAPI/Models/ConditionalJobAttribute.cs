namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConditionalJobAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConditionalJobAttribute()
        {
            MonitorConditionalJobAttributes = new HashSet<MonitorConditionalJobAttribute>();
        }

        public int ConditionalJobAttributeID { get; set; }

        [Required]
        public string Name { get; set; }

        public int FilterID { get; set; }

        public int TemplateJobID { get; set; }

        public bool Override { get; set; }

        public virtual Filter Filter { get; set; }

        public virtual Job Job { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonitorConditionalJobAttribute> MonitorConditionalJobAttributes { get; set; }
    }
}
