namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            DestinationDevices = new HashSet<DestinationDevice>();
        }

        public int DeviceID { get; set; }

        public Guid DeviceUID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Online { get; set; }

        public int FolderID { get; set; }

        public int DeviceTypeID { get; set; }

        [Required]
        public string Machine { get; set; }

        public int? Port { get; set; }

        public string Host { get; set; }

        public string URI { get; set; }

        public string QueueName { get; set; }

        public string URI_2 { get; set; }

        public int PPM { get; set; }

        public int BytesPerPage { get; set; }

        public int JobResponseTimeSecs { get; set; }

        public bool SNMPEnabled { get; set; }

        [Required]
        public string SNMPCommunityName { get; set; }

        public int SNMPTimeout { get; set; }

        public int SNMPRetryCount { get; set; }

        public int SNMPErrorMask { get; set; }

        public double CostPerJob { get; set; }

        public double CostPerPage { get; set; }

        public double CostPerImpression { get; set; }

        public bool EnableAccountingLogs { get; set; }

        public string AccountingLogFDF { get; set; }

        public string AccountingLogWatchFolder { get; set; }

        public string AccountingLogWatchFilter { get; set; }

        public int AccountingLogColumnDelimiter { get; set; }

        public bool DiscardNonSOLitrackAccountingData { get; set; }

        public bool PreserveTrackingDataInOutput { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationDevice> DestinationDevices { get; set; }

        public virtual DeviceTypeString DeviceTypeString { get; set; }
    }
}
