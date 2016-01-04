namespace JobsAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Folder()
        {
            Folders1 = new HashSet<Folder>();
            Sites = new HashSet<Site>();
            Stations = new HashSet<Station>();
            UserJobFilters = new HashSet<UserJobFilter>();
        }

        public int FolderID { get; set; }

        public Guid FolderUID { get; set; }

        public int? ParentFolderID { get; set; }

        [Required]
        public string Name { get; set; }

        public int FolderTypeID { get; set; }

        public int FolderSpecializedTypeID { get; set; }

        public int FolderScopeID { get; set; }

        [StringLength(255)]
        public string UserSID { get; set; }

        public int? FilterID { get; set; }

        public bool Inherit { get; set; }

        public bool AutoPurge { get; set; }

        public int AutoPurgeDays { get; set; }

        public Guid? SiteUID { get; set; }

        public virtual FolderScope FolderScope { get; set; }

        public virtual FolderType FolderType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Folder> Folders1 { get; set; }

        public virtual Folder Folder1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site> Sites { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Station> Stations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserJobFilter> UserJobFilters { get; set; }
    }
}
