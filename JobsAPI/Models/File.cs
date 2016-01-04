namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class File
    {
        public int FileID { get; set; }

        public Guid FileUID { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        [Required]
        [StringLength(255)]
        public string StoredFileName { get; set; }

        public int StorageFolderID { get; set; }

        public long FileSize { get; set; }

        public DateTime Created { get; set; }

        public DateTime Added { get; set; }

        public DateTime Modified { get; set; }

        public int FileTypeID { get; set; }

        public int JobTicketTypeID { get; set; }

        public int JobTicketLength { get; set; }

        public bool Purged { get; set; }

        public virtual StorageFolder StorageFolder { get; set; }
    }
}
