namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AggregateJob
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }
    }
}
