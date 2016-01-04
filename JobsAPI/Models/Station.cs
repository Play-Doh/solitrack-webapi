namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Station()
        {
            Destinations = new HashSet<Destination>();
        }

        public int StationID { get; set; }

        public Guid StationUID { get; set; }

        [Required]
        public string StationName { get; set; }

        public string StationDescription { get; set; }

        [Required]
        public string StationMachine { get; set; }

        public int StationFolderID { get; set; }

        public virtual Folder Folder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
