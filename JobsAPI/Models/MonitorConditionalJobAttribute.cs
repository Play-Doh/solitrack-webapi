namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MonitorConditionalJobAttribute
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MonitorID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConditionalJobAttributeID { get; set; }

        public int DisplayOrder { get; set; }

        public virtual ConditionalJobAttribute ConditionalJobAttribute { get; set; }

        public virtual Monitor Monitor { get; set; }
    }
}
