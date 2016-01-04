namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicationSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplicationSettingsID { get; set; }

        public bool MailEnabled { get; set; }

        public string MailServer { get; set; }

        public string ReportServerURL { get; set; }

        public string MailFrom { get; set; }

        public bool AutoPurgeFiles { get; set; }

        public bool AutoPurgeRecycleBin { get; set; }

        public int AutoPurgeRecycleBinDays { get; set; }

        public int MaxQueryRows { get; set; }

        public int MaxActiveJobMins { get; set; }

        public int RefreshInterval { get; set; }

        public bool EnableSiteUpdates { get; set; }

        public string ParentSiteURL { get; set; }

        public Guid? ParentSiteUID { get; set; }

        [Required]
        public string SiteName { get; set; }

        public Guid SiteUID { get; set; }

        public DateTime? SiteLastUpdatedOn { get; set; }

        [StringLength(255)]
        public string SiteLastUpdateDetails { get; set; }

        public int? MailPort { get; set; }

        public string MailUsername { get; set; }

        public string MailPassword { get; set; }

        public bool AutoPurgeEventLog { get; set; }

        public int AutoPurgeEventLogDays { get; set; }

        public int MaxEventQueryRows { get; set; }
    }
}
