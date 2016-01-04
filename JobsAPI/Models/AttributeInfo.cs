namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttributeInfo")]
    public partial class AttributeInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttributeInfo()
        {
            JobDisplayColumns = new HashSet<JobDisplayColumn>();
            FilterAtoms = new HashSet<FilterAtom>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttributeID { get; set; }

        public Guid AttributeUID { get; set; }

        public bool IsUpdatable { get; set; }

        public bool IsFilterable { get; set; }

        public bool IsUpdateDisplayable { get; set; }

        public bool IsQueryDisplayable { get; set; }

        public int? DefaultDisplayOrder { get; set; }

        public string QueryName { get; set; }

        [Required]
        public string ColumnName { get; set; }

        [Required]
        public string Label { get; set; }

        public int AttributeCategoryID { get; set; }

        public int AttributeGroupID { get; set; }

        public int AttributeTypeID { get; set; }

        public bool CanBeNull { get; set; }

        public bool Obsolete { get; set; }

        public virtual AttributeCategory AttributeCategory { get; set; }

        public virtual AttributeGroup AttributeGroup { get; set; }

        public virtual AttributeTypeString AttributeTypeString { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobDisplayColumn> JobDisplayColumns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilterAtom> FilterAtoms { get; set; }
    }
}
