namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SchemaVersion
    {
        public int SchemaVersionID { get; set; }

        public int Major { get; set; }

        public int Minor { get; set; }

        public int SubMajor { get; set; }

        public int SubMinor { get; set; }

        public DateTime DateApplied { get; set; }
    }
}
