namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkflowTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkflowTransaction()
        {
            Jobs = new HashSet<Job>();
        }

        public int WorkflowTransactionID { get; set; }

        public int WorkflowID { get; set; }

        public int WorkflowRootJobID { get; set; }

        public DateTime WorkflowStarted { get; set; }

        public int WorkflowActivities { get; set; }

        public int WorkflowCompletedActivities { get; set; }

        public int CumulativeEstCompletionMin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }

        public virtual Workflow Workflow { get; set; }
    }
}
