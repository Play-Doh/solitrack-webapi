namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Site()
        {
            JobReconciliationBatches = new HashSet<JobReconciliationBatch>();
            Jobs = new HashSet<Job>();
        }

        public int SiteID { get; set; }

        [Required]
        public string SiteName { get; set; }

        [Required]
        public string SiteURL { get; set; }

        public Guid SiteUID { get; set; }

        public int SiteJobFolderID { get; set; }

        public bool SiteMarkedForRemoval { get; set; }

        public int SiteJobIDMarker { get; set; }

        public int SiteUpdateIDMarker { get; set; }

        public int SiteDeletionIDMarker { get; set; }

        public int SiteJobMessageIDMarker { get; set; }

        public int SiteJobMediumIDMarker { get; set; }

        public int SiteBatchSize { get; set; }

        public DateTime? LastSiteUpdate { get; set; }

        public virtual Folder Folder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobReconciliationBatch> JobReconciliationBatches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
