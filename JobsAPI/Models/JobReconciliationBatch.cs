namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobReconciliationBatch")]
    public partial class JobReconciliationBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobReconciliationBatch()
        {
            JobReconciliations = new HashSet<JobReconciliation>();
        }

        public int JobReconciliationBatchID { get; set; }

        public int SiteID { get; set; }

        public string UpdateTable { get; set; }

        public string JobAncestorTable { get; set; }

        public string DeletionTable { get; set; }

        public string JobMessageTable { get; set; }

        public string JobMediumTable { get; set; }

        public int? BatchCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobReconciliation> JobReconciliations { get; set; }

        public virtual Site Site { get; set; }
    }
}
