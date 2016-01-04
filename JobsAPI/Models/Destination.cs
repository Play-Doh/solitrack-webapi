namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Destination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Destination()
        {
            DestinationDevices = new HashSet<DestinationDevice>();
            Stations = new HashSet<Station>();
        }

        public int DestinationID { get; set; }

        public Guid DestinationUID { get; set; }

        [Required]
        [StringLength(255)]
        public string DestinationName { get; set; }

        public string Description { get; set; }

        public int FolderID { get; set; }

        public int DeviceSelectionModeID { get; set; }

        public int RetryCount { get; set; }

        public int RetryIntervalSecs { get; set; }

        public bool StopProcessingOnError { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationDevice> DestinationDevices { get; set; }

        public virtual DeviceSelectionModeString DeviceSelectionModeString { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Station> Stations { get; set; }
    }
}
