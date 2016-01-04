namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alert
    {
        public int AlertID { get; set; }

        public bool Enabled { get; set; }

        [Required]
        public string Description { get; set; }

        public int EventID { get; set; }

        public int FilterID { get; set; }

        public int? ContactListID { get; set; }

        public int ResponseDelaySeconds { get; set; }

        public bool ResponseEMail { get; set; }

        public bool ResponseLogEvent { get; set; }

        [Required]
        public string ResponseMessage { get; set; }

        public int ScanIntervalSeconds { get; set; }

        public bool AlertOnNoFilterResults { get; set; }

        public string WebhookURI { get; set; }

        public virtual ContactList ContactList { get; set; }

        public virtual Event Event { get; set; }

        public virtual Filter Filter { get; set; }
    }
}
