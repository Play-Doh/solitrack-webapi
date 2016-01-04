namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobSelection
    {
        [Key]
        [Column(Order = 0)]
        public Guid SelectionUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SelectedJobID { get; set; }

        public int SelectionOrder { get; set; }

        public virtual Job Job { get; set; }

        public virtual Selection Selection { get; set; }
    }
}
