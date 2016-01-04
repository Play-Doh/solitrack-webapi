namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Activity
    {
        public int ActivityID { get; set; }

        public Guid ActivityUID { get; set; }

        public int WorkflowID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int ActivityEndCheckpointID { get; set; }

        public bool IsAsynchronous { get; set; }

        public int? NextActivityID { get; set; }

        public int? DisplayOrder { get; set; }

        public int? EstCompletionMin { get; set; }

        public int? CumalativeEstCompletionMin { get; set; }

        public virtual Checkpoint Checkpoint { get; set; }

        public virtual Workflow Workflow { get; set; }
    }
}
