namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobMessage
    {
        public int JobMessageID { get; set; }

        public int JobID { get; set; }

        [Required]
        public string Message { get; set; }

        public int MessageTypeID { get; set; }

        public DateTime Timestamp { get; set; }

        public virtual Job Job { get; set; }

        public virtual MessageTypeString MessageTypeString { get; set; }
    }
}
