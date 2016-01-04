namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobStateString
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobStateID { get; set; }

        [Column("JobStateString")]
        [Required]
        public string JobStateString1 { get; set; }
    }
}
