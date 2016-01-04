namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrphanedJob
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrphanedJobID { get; set; }

        [Required]
        [StringLength(255)]
        public string ParentJobIDSPDE { get; set; }
    }
}
