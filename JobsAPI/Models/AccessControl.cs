namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessControl")]
    public partial class AccessControl
    {
        [Key]
        [Column(Order = 0)]
        public Guid ResourceUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string TrusteeSID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccessMask { get; set; }
    }
}
