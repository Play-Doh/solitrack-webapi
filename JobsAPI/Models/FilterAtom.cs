namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FilterAtom
    {
        public int FilterAtomID { get; set; }

        public int FilterID { get; set; }

        public int AttributeID { get; set; }

        public int FilterOperatorID { get; set; }

        [Required]
        public string Value { get; set; }

        public bool OR { get; set; }

        public int DisplayOrder { get; set; }

        public virtual AttributeInfo AttributeInfo { get; set; }

        public virtual Filter Filter { get; set; }

        public virtual FilterOperatorString FilterOperatorString { get; set; }
    }
}
