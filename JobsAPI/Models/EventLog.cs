namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventLog")]
    public partial class EventLog
    {
        public int EventLogID { get; set; }

        public int EventID { get; set; }

        public int EventTypeID { get; set; }

        public DateTime EventTimestamp { get; set; }

        [Required]
        [StringLength(255)]
        public string EventSource { get; set; }

        [StringLength(255)]
        public string EventMessage { get; set; }

        [StringLength(1024)]
        public string EventDetails { get; set; }

        [StringLength(255)]
        public string EventUser { get; set; }

        [StringLength(255)]
        public string EventDevice { get; set; }

        [StringLength(255)]
        public string EventMachine { get; set; }

        [StringLength(1024)]
        public string EventData { get; set; }

        public int? ID1 { get; set; }

        public int? ID2 { get; set; }

        public int? ID3 { get; set; }

        public virtual Event Event { get; set; }

        public virtual EventTypeString EventTypeString { get; set; }
    }
}
