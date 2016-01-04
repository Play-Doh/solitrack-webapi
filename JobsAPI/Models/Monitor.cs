namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Monitor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monitor()
        {
            ApplicationResourceLocks = new HashSet<ApplicationResourceLock>();
            MonitorConditionalJobAttributes = new HashSet<MonitorConditionalJobAttribute>();
            MonitorFileNameAttributes = new HashSet<MonitorFileNameAttribute>();
        }

        public int MonitorID { get; set; }

        public Guid MonitorUID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string WatchFolder { get; set; }

        [Required]
        public string FileFilter { get; set; }

        public string REFilter { get; set; }

        public string FileNameRE { get; set; }

        public int StorageFolderID { get; set; }

        public int TemplateJobID { get; set; }

        public bool Running { get; set; }

        public bool PostProcessMove { get; set; }

        public string MoveFolder { get; set; }

        public bool FileStabilizationEnabled { get; set; }

        public int StabilizationPeriod { get; set; }

        public bool StabilizeOnLastWriteTime { get; set; }

        public bool? AutoSubmit { get; set; }

        [Required]
        public string Usage { get; set; }

        public DateTime? LastUsedOn { get; set; }

        public int? WorkflowID { get; set; }

        public bool EnableAutoRetry { get; set; }

        public int AutoRetryCount { get; set; }

        public int AutoRetryDelaySecs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationResourceLock> ApplicationResourceLocks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonitorConditionalJobAttribute> MonitorConditionalJobAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonitorFileNameAttribute> MonitorFileNameAttributes { get; set; }

        public virtual StorageFolder StorageFolder { get; set; }

        public virtual Workflow Workflow { get; set; }
    }
}
