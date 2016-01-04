namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobTicketTypeString
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobTicketTypeID { get; set; }

        [Column("JobTicketTypeString")]
        [Required]
        public string JobTicketTypeString1 { get; set; }
    }
}
