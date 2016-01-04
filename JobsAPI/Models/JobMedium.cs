namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobMedium
    {
        [Key]
        public int MediumEntryID { get; set; }

        public int JobID { get; set; }

        public int MediumTray { get; set; }

        public int? MediumSheetsPrinted { get; set; }

        public int? MediumSheetsPrintedSimplex { get; set; }

        public int? MediumSheetsPrintedDuplex { get; set; }

        public string MediumName { get; set; }

        public string MediumType { get; set; }

        public string MediumSize { get; set; }

        public string MediumColor { get; set; }

        public string MediumWeight { get; set; }
    }
}
