namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FileTypeString
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileTypeID { get; set; }

        [Column("FileTypeString")]
        [Required]
        public string FileTypeString1 { get; set; }
    }
}
