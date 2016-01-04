namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationResourceLock
    {
        [Key]
        public int LockID { get; set; }

        public int? LockedMonitorID { get; set; }

        public int? LockedCheckpointID { get; set; }

        [Required]
        public string MachineName { get; set; }

        [Required]
        public string ApplicationName { get; set; }

        [Required]
        public string ApplicationKey { get; set; }

        public DateTime LockedOn { get; set; }

        public virtual Checkpoint Checkpoint { get; set; }

        public virtual Monitor Monitor { get; set; }
    }
}
