namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobStateGroupString
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobStateGroupID { get; set; }

        [Column("JobStateGroupString")]
        [Required]
        public string JobStateGroupString1 { get; set; }
    }
}
