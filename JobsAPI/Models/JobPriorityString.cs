namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobPriorityString
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobPriorityID { get; set; }

        [Column("JobPriorityString")]
        [Required]
        public string JobPriorityString1 { get; set; }
    }
}
