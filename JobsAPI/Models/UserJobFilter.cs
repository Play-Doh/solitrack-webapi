namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserJobFilter
    {
        public int UserJobFilterID { get; set; }

        public int FilterID { get; set; }

        public int? JobFilterFolderID { get; set; }

        public string UserSID { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsJobView { get; set; }

        public virtual Filter Filter { get; set; }

        public virtual Folder Folder { get; set; }
    }
}
